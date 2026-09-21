// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeMonitorAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of member account information.</para>
        /// </summary>
        [NameInMap("AccountIdInfos")]
        [Validation(Required=false)]
        public List<DescribeMonitorAccountsResponseBodyAccountIdInfos> AccountIdInfos { get; set; }
        public class DescribeMonitorAccountsResponseBodyAccountIdInfos : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>119593010538****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The time when the account was added to the management list. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1760520684000</para>
            /// </summary>
            [NameInMap("AddTime")]
            [Validation(Required=false)]
            public long? AddTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>106635707417****</para>
            /// </summary>
            [NameInMap("OperatorUid")]
            [Validation(Required=false)]
            public string OperatorUid { get; set; }

            /// <summary>
            /// <para>The basic service switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: off</description></item>
            /// <item><description><b>1</b>: on</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PostBasicService")]
            [Validation(Required=false)]
            public int? PostBasicService { get; set; }

            /// <summary>
            /// <para>The purchased edition of Security Center. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> or <b>1</b>: Free Edition</description></item>
            /// <item><description><b>2</b> or <b>3</b>: Enterprise Edition  </description></item>
            /// <item><description><b>5</b>: Advanced Edition  </description></item>
            /// <item><description><b>6</b>: Anti-virus Edition </description></item>
            /// <item><description><b>7</b>: Ultimate Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("SasVersion")]
            [Validation(Required=false)]
            public string SasVersion { get; set; }

        }

        /// <summary>
        /// <para>The list of member account IDs.</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>028CF634-5268-5660-9575-48C9ED6BF880</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
