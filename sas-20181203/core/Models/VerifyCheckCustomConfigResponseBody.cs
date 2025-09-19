// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckCustomConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>List of check parameters with configuration errors.</para>
        /// </summary>
        [NameInMap("ErrorCheckConfigs")]
        [Validation(Required=false)]
        public List<VerifyCheckCustomConfigResponseBodyErrorCheckConfigs> ErrorCheckConfigs { get; set; }
        public class VerifyCheckCustomConfigResponseBodyErrorCheckConfigs : TeaModel {
            /// <summary>
            /// <para>Error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ConfigEqualIllegal</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>Error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom parameter is not equal to corresponding check parameter</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>Related configurations causing this error.</para>
            /// </summary>
            [NameInMap("LinkErrorConfigs")]
            [Validation(Required=false)]
            public List<VerifyCheckCustomConfigResponseBodyErrorCheckConfigsLinkErrorConfigs> LinkErrorConfigs { get; set; }
            public class VerifyCheckCustomConfigResponseBodyErrorCheckConfigsLinkErrorConfigs : TeaModel {
                /// <summary>
                /// <para>Name of the check item configuration, unique within the same check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IpLists</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Display name of the user\&quot;s check configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IP Lists</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The type of the parameter that caused the error:</para>
                /// <list type="bullet">
                /// <item><description>repair: Repair parameter</description></item>
                /// <item><description>custom: Custom configuration parameter</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>repair</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Name of the custom configuration item for the check item, unique within the same check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IpList</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Type of the erroneous parameter:</para>
            /// <list type="bullet">
            /// <item><description>custom: Custom configuration parameter</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>User-configured value string for the custom configuration item of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.12.4.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Check the error code returned by the custom check item.</para>
        /// </summary>
        [NameInMap("ErrorCheckCustomConfig")]
        [Validation(Required=false)]
        public VerifyCheckCustomConfigResponseBodyErrorCheckCustomConfig ErrorCheckCustomConfig { get; set; }
        public class VerifyCheckCustomConfigResponseBodyErrorCheckCustomConfig : TeaModel {
            /// <summary>
            /// <para>Error code when failed. This parameter is not returned upon success. </para>
            /// <list type="bullet">
            /// <item><description><b>CspmVerifyCheckCustomItemNoPass</b>: The asset did not pass the set custom rules. </description></item>
            /// <item><description><b>CspmVerifyCheckCustomItemError</b>: Verification error, there is an issue with the input rule.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CspmVerifyCheckCustomItemNoPass</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>Error message</para>
            /// 
            /// <b>Example:</b>
            /// <para>Creation verification failed.</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

        }

        /// <summary>
        /// <para>List of repair parameters with configuration check errors.</para>
        /// </summary>
        [NameInMap("ErrorRepairConfigs")]
        [Validation(Required=false)]
        public List<VerifyCheckCustomConfigResponseBodyErrorRepairConfigs> ErrorRepairConfigs { get; set; }
        public class VerifyCheckCustomConfigResponseBodyErrorRepairConfigs : TeaModel {
            /// <summary>
            /// <para>Error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ConfigEqualIllegal</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>Error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Repair parameter is not equal to corresponding check parameter</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>Related configurations causing this error.</para>
            /// </summary>
            [NameInMap("LinkErrorConfigs")]
            [Validation(Required=false)]
            public List<VerifyCheckCustomConfigResponseBodyErrorRepairConfigsLinkErrorConfigs> LinkErrorConfigs { get; set; }
            public class VerifyCheckCustomConfigResponseBodyErrorRepairConfigsLinkErrorConfigs : TeaModel {
                /// <summary>
                /// <para>Name of the check item\&quot;s configuration, unique within the same check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IpList</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Display name of the user\&quot;s check configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ip List</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The type of the parameter that caused the error:</para>
                /// <list type="bullet">
                /// <item><description>repair: Repair parameter</description></item>
                /// <item><description>custom: Custom configuration parameter</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Name of the check item\&quot;s repair configuration, unique within the same check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IpLists</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the parameter that caused the error:</para>
            /// <list type="bullet">
            /// <item><description>repair: Repair parameter</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>repair</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Name of the check item\&quot;s repair parameter, unique within the same check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.26.49.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of this call request, a unique identifier generated by Alibaba Cloud for the request, which can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
