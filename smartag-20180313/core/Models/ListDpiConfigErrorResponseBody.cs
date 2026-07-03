// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListDpiConfigErrorResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of DPI configuration errors.</para>
        /// </summary>
        [NameInMap("DpiConfigError")]
        [Validation(Required=false)]
        public List<ListDpiConfigErrorResponseBodyDpiConfigError> DpiConfigError { get; set; }
        public class ListDpiConfigErrorResponseBodyDpiConfigError : TeaModel {
            /// <summary>
            /// <para>The type of the configuration error.</para>
            /// <list type="bullet">
            /// <item><description>DeviceNotSupported: The Smart Access Gateway device does not support the DPI feature.</description></item>
            /// <item><description>VersionNotSupported: The DPI version of the Smart Access Gateway device is too old.</description></item>
            /// <item><description><b>NotEnable</b>: The DPI feature is disabled for the Smart Access Gateway device.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DeviceNotSupported</para>
            /// </summary>
            [NameInMap("ErrorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }

            /// <summary>
            /// <para>A list of rule configuration errors.</para>
            /// </summary>
            [NameInMap("RuleConfigErrorList")]
            [Validation(Required=false)]
            public List<ListDpiConfigErrorResponseBodyDpiConfigErrorRuleConfigErrorList> RuleConfigErrorList { get; set; }
            public class ListDpiConfigErrorResponseBodyDpiConfigErrorRuleConfigErrorList : TeaModel {
                /// <summary>
                /// <para>A list of IDs of application groups that have configuration errors.</para>
                /// </summary>
                [NameInMap("DpiGroupIds")]
                [Validation(Required=false)]
                public List<string> DpiGroupIds { get; set; }

                /// <summary>
                /// <para>A list of IDs of applications that have configuration errors.</para>
                /// </summary>
                [NameInMap("DpiSignatureIds")]
                [Validation(Required=false)]
                public List<string> DpiSignatureIds { get; set; }

                /// <summary>
                /// <para>The ID of the rule that is associated with the application that has a configuration error.</para>
                /// <list type="bullet">
                /// <item><description>If you query DPI configuration errors for Resource Access Management, this parameter indicates the ID of the Resource Access Management rule instance that has a configuration error.</description></item>
                /// <item><description>If you query DPI configuration errors for a QoS policy, this parameter indicates the ID of the quintuple rule instance that has a configuration error.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>qospy-axud4s62gz632b****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

            }

            /// <summary>
            /// <para>The serial number of the Smart Access Gateway device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag-2160808****</para>
            /// </summary>
            [NameInMap("SN")]
            [Validation(Required=false)]
            public string SN { get; set; }

            /// <summary>
            /// <para>The ID of the Smart Access Gateway instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag-1e8sgws6b133b8****</para>
            /// </summary>
            [NameInMap("SmartAGId")]
            [Validation(Required=false)]
            public string SmartAGId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of configuration errors to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F47B5293-27B6-48EF-A9C6-E90A41449813</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of DPI configuration errors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
