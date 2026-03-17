// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListDpiConfigErrorResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the configuration errors.</para>
        /// </summary>
        [NameInMap("DpiConfigError")]
        [Validation(Required=false)]
        public List<ListDpiConfigErrorResponseBodyDpiConfigError> DpiConfigError { get; set; }
        public class ListDpiConfigErrorResponseBodyDpiConfigError : TeaModel {
            /// <summary>
            /// <para>The type of the configuration error. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DeviceNotSupported</b>: The SAG instance does not support the DPI feature.</description></item>
            /// <item><description><b>VersionNotSupported</b>: The version of the DPI feature is outdated.</description></item>
            /// <item><description><b>NotEnable</b>: The DPI feature is disabled on the SAG instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DeviceNotSupported</para>
            /// </summary>
            [NameInMap("ErrorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }

            /// <summary>
            /// <para>The information about the configuration errors.</para>
            /// </summary>
            [NameInMap("RuleConfigErrorList")]
            [Validation(Required=false)]
            public List<ListDpiConfigErrorResponseBodyDpiConfigErrorRuleConfigErrorList> RuleConfigErrorList { get; set; }
            public class ListDpiConfigErrorResponseBodyDpiConfigErrorRuleConfigErrorList : TeaModel {
                /// <summary>
                /// <para>The IDs of the application groups that have configuration errors.</para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/196754.html">ListDpiGroups</a> operation to query application group IDs and information about the applications.</para>
                /// </summary>
                [NameInMap("DpiGroupIds")]
                [Validation(Required=false)]
                public List<string> DpiGroupIds { get; set; }

                /// <summary>
                /// <para>The IDs of applications that have configuration errors.</para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/196630.html">ListDpiSignatures</a> operation to query application IDs and information about the applications.</para>
                /// </summary>
                [NameInMap("DpiSignatureIds")]
                [Validation(Required=false)]
                public List<string> DpiSignatureIds { get; set; }

                /// <summary>
                /// <para>The IDs of rules that are applied to applications with configuration errors.</para>
                /// <list type="bullet">
                /// <item><description>If you make the request to query configuration errors of ACLs, the IDs of ACL rules that have configuration errors are returned.</description></item>
                /// <item><description>If you make the request to query configuration errors of QoS polices, the IDs of the 5-tuples in the QoS polices that have configuration errors are returned.</description></item>
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
            /// <para>The serial number of the SAG instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag-2160808****</para>
            /// </summary>
            [NameInMap("SN")]
            [Validation(Required=false)]
            public string SN { get; set; }

            /// <summary>
            /// <para>The ID of the SAG instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag-1e8sgws6b133b8****</para>
            /// </summary>
            [NameInMap("SmartAGId")]
            [Validation(Required=false)]
            public string SmartAGId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that was used to query the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F47B5293-27B6-48EF-A9C6-E90A41449813</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
