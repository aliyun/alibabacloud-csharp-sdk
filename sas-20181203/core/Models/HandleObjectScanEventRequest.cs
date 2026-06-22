// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleObjectScanEventRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the type for batch processing of similar alerts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sha256</b>: by file content</description></item>
        /// <item><description><b>eventName</b>: by alert name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sha256</para>
        /// </summary>
        [NameInMap("BatchType")]
        [Validation(Required=false)]
        public string BatchType { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The list of event IDs.</para>
        /// </summary>
        [NameInMap("EventIdList")]
        [Validation(Required=false)]
        public List<long?> EventIdList { get; set; }

        /// <summary>
        /// <para>The language of the content in the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The list of whitelist rules. This parameter takes effect only when the alert is whitelisted.</para>
        /// </summary>
        [NameInMap("RuleConditionList")]
        [Validation(Required=false)]
        public List<HandleObjectScanEventRequestRuleConditionList> RuleConditionList { get; set; }
        public class HandleObjectScanEventRequestRuleConditionList : TeaModel {
            /// <summary>
            /// <para>The whitelist field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ossKey</b>: file path</description></item>
            /// <item><description><b>bucketName</b>: bucket name</description></item>
            /// <item><description><b>md5</b>: file MD5</description></item>
            /// <item><description><b>sha256</b>: file SHA-256.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ossKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The operator. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>contains</b>: Contains.</description></item>
            /// <item><description><b>not_contains</b>: Does not contain.</description></item>
            /// <item><description><b>str_equal</b>: Equals.</description></item>
            /// <item><description><b>str_not_equal</b>: Does not equal.</description></item>
            /// <item><description><b>regex</b>: Regular expression.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>contains</para>
            /// </summary>
            [NameInMap("Operate")]
            [Validation(Required=false)]
            public string Operate { get; set; }

            /// <summary>
            /// <para>The value to match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sshe</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The target status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unhandled.</description></item>
        /// <item><description><b>1</b>: Manually handled.</description></item>
        /// <item><description><b>2</b>: Whitelisted.</description></item>
        /// <item><description><b>3</b>: Ignored.</description></item>
        /// <item><description><b>4</b>: Access denied.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
