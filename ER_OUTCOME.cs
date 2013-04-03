using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using VeteransAffairs.Registries.Validation;

namespace VeteransAffairs.Registries.Business
{
    [Serializable()]
    public partial class ER_OUTCOME
    {
        #region private properties

        private ValidationErrorsCollection _BrokenRules = new ValidationErrorsCollection();
        
        #endregion

        #region Public Properties

        /// <summary>
        /// Property to inform if the object is being loaded from a postback.
        /// </summary>
        public bool LoadedWithDisconnectedStateChanges { get; set; }

        /// <summary>
        /// Ref Property containing list of broken business rules.
        /// </summary>
        public ValidationErrorsCollection BrokenRules
        {
            get
            {
                return _BrokenRules;
            }
        }


        #endregion

        #region Entity Events

        

        #endregion

        #region Public Methods


        #endregion

        #region Business Rules

        public int EnforceBusinessRules(bool SavingData, RegistriesDataAccess db)
        {
            _BrokenRules.Clear();

            RuleObjectRelationshipsRequiredReferenceObjects(db);

            RuleConfigurePropertiesForValidatorControls();

            return 0;
        }

  

        private void RuleObjectRelationshipsRequiredReferenceObjects(RegistriesDataAccess db) 
        {
            
        }

        
    

        private void RuleConfigurePropertiesForValidatorControls ()
        {
            
            

        }

  
        #endregion

        #region Properties for Validator Controls

    

        #endregion

        

    }

 
}