// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateSecurityStrategyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9*****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public UpdateSecurityStrategyRequestContent Content { get; set; }
        public class UpdateSecurityStrategyRequestContent : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Controllers")]
            [Validation(Required=false)]
            public List<UpdateSecurityStrategyRequestContentControllers> Controllers { get; set; }
            public class UpdateSecurityStrategyRequestContentControllers : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("BasicEditionDefaultValue")]
                [Validation(Required=false)]
                public object BasicEditionDefaultValue { get; set; }

                [NameInMap("BasicEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> BasicEditionIntervalValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>viewCount</para>
                /// </summary>
                [NameInMap("Controller")]
                [Validation(Required=false)]
                public string Controller { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Integer</para>
                /// </summary>
                [NameInMap("ControllerValueType")]
                [Validation(Required=false)]
                public string ControllerValueType { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Query Results - Single Display Record Limit</para>
                /// </summary>
                [NameInMap("DisplayNameEn")]
                [Validation(Required=false)]
                public string DisplayNameEn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("EnterpriseEditionDefaultValue")]
                [Validation(Required=false)]
                public object EnterpriseEditionDefaultValue { get; set; }

                [NameInMap("EnterpriseEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> EnterpriseEditionIntervalValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("ProfessionalEditionDefaultValue")]
                [Validation(Required=false)]
                public object ProfessionalEditionDefaultValue { get; set; }

                [NameInMap("ProfessionalEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> ProfessionalEditionIntervalValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("StandardEditionDefaultValue")]
                [Validation(Required=false)]
                public object StandardEditionDefaultValue { get; set; }

                [NameInMap("StandardEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> StandardEditionIntervalValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("UserConfigValue")]
                [Validation(Required=false)]
                public object UserConfigValue { get; set; }

            }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public List<long?> Workspaces { get; set; }

    }

}
