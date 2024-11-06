// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainCcActivityLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The log data of the event that triggered rate limiting.</para>
        /// </summary>
        [NameInMap("ActivityLog")]
        [Validation(Required=false)]
        public List<DescribeDcdnDomainCcActivityLogResponseBodyActivityLog> ActivityLog { get; set; }
        public class DescribeDcdnDomainCcActivityLogResponseBodyActivityLog : TeaModel {
            /// <summary>
            /// <para>The action that was triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The accelerated domain name whose ICP filing status you want to update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The name of the rule that was triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test2</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The timestamp of the data returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-12-10T20:00:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            /// <summary>
            /// <para>The object that triggered the blocking event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IP</para>
            /// </summary>
            [NameInMap("TriggerObject")]
            [Validation(Required=false)]
            public string TriggerObject { get; set; }

            /// <summary>
            /// <para>The period of time during which rate limiting remains effective.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public long? Ttl { get; set; }

            /// <summary>
            /// <para>The value of the trigger for rate limiting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.10.10.10</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C6CCEC4-6B88-4D4A-93E4-D47B3D92CF8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
