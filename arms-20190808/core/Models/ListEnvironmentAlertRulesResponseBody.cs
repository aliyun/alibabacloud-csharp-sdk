// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvironmentAlertRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The struct returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEnvironmentAlertRulesResponseBodyData Data { get; set; }
        public class ListEnvironmentAlertRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The queried alert groups.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<string> Groups { get; set; }

            /// <summary>
            /// <para>The queried rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListEnvironmentAlertRulesResponseBodyDataRules> Rules { get; set; }
            public class ListEnvironmentAlertRulesResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The ID of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9502571</para>
                /// </summary>
                [NameInMap("AlertId")]
                [Validation(Required=false)]
                public long? AlertId { get; set; }

                /// <summary>
                /// <para>The name of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql-CS-MySQLInnoDBLogWaits_lu</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C518054-852F-4023-ABC1-4AF95FF7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
