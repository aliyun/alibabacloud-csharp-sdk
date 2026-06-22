// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class VerifyCheckCustomConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of check parameters that have configuration check errors.</para>
        /// </summary>
        [NameInMap("ErrorCheckConfigs")]
        [Validation(Required=false)]
        public List<VerifyCheckCustomConfigResponseBodyErrorCheckConfigs> ErrorCheckConfigs { get; set; }
        public class VerifyCheckCustomConfigResponseBodyErrorCheckConfigs : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ConfigEqualIllegal</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom parameter is not equal to corresponding check parameter</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The related configurations that caused this error.</para>
            /// </summary>
            [NameInMap("LinkErrorConfigs")]
            [Validation(Required=false)]
            public List<VerifyCheckCustomConfigResponseBodyErrorCheckConfigsLinkErrorConfigs> LinkErrorConfigs { get; set; }
            public class VerifyCheckCustomConfigResponseBodyErrorCheckConfigsLinkErrorConfigs : TeaModel {
                /// <summary>
                /// <para>The name of the check item configuration. The name is unique within the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IpLists</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The display name of the user check configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IP Lists</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The type of the parameter that has an error. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>repair: repair parameter</description></item>
                /// <item><description>custom: custom configuration parameter.</description></item>
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
            /// <para>The name of the custom configuration item for the check item. The name is unique within the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IpList</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the parameter that has an error. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>custom: custom configuration parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The user-configured value string of the custom configuration item for the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.12.4.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The error code returned for the custom check item validation.</para>
        /// </summary>
        [NameInMap("ErrorCheckCustomConfig")]
        [Validation(Required=false)]
        public VerifyCheckCustomConfigResponseBodyErrorCheckCustomConfig ErrorCheckCustomConfig { get; set; }
        public class VerifyCheckCustomConfigResponseBodyErrorCheckCustomConfig : TeaModel {
            /// <summary>
            /// <para>The error code returned upon failure. This parameter is not returned upon success. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CspmVerifyCheckCustomItemNoPass</b>: The asset did not pass the custom rule that was configured.</description></item>
            /// <item><description><b>CspmVerifyCheckCustomItemError</b>: A validation error occurred because the input rule has issues.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CspmVerifyCheckCustomItemNoPass</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The exception information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Creation verification failed.</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

        }

        /// <summary>
        /// <para>The list of repair parameters that have configuration check errors.</para>
        /// </summary>
        [NameInMap("ErrorRepairConfigs")]
        [Validation(Required=false)]
        public List<VerifyCheckCustomConfigResponseBodyErrorRepairConfigs> ErrorRepairConfigs { get; set; }
        public class VerifyCheckCustomConfigResponseBodyErrorRepairConfigs : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ConfigEqualIllegal</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Repair parameter is not equal to corresponding check parameter</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The related configurations that caused this error.</para>
            /// </summary>
            [NameInMap("LinkErrorConfigs")]
            [Validation(Required=false)]
            public List<VerifyCheckCustomConfigResponseBodyErrorRepairConfigsLinkErrorConfigs> LinkErrorConfigs { get; set; }
            public class VerifyCheckCustomConfigResponseBodyErrorRepairConfigsLinkErrorConfigs : TeaModel {
                /// <summary>
                /// <para>The name of the check item configuration. The name is unique within the check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IpList</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The display name of the user check configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ip List</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>The type of the parameter that has an error. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>repair: repair parameter</description></item>
                /// <item><description>custom: custom configuration parameter.</description></item>
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
            /// <para>The name of the repair configuration item for the check item. The name is unique within the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IpLists</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the parameter that has an error. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>repair: repair parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>repair</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The name of the repair parameter for the check item. The name is unique within the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.26.49.XX</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447DD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
