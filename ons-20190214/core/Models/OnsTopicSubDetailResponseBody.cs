// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicSubDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsTopicSubDetailResponseBodyData Data { get; set; }
        public class OnsTopicSubDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the online consumer groups that subscribe to the topic.</para>
            /// </summary>
            [NameInMap("SubscriptionDataList")]
            [Validation(Required=false)]
            public OnsTopicSubDetailResponseBodyDataSubscriptionDataList SubscriptionDataList { get; set; }
            public class OnsTopicSubDetailResponseBodyDataSubscriptionDataList : TeaModel {
                [NameInMap("SubscriptionDataList")]
                [Validation(Required=false)]
                public List<OnsTopicSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList> SubscriptionDataList { get; set; }
                public class OnsTopicSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList : TeaModel {
                    /// <summary>
                    /// <para>The ID of the consumer group that subscribes to the topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GID_test</para>
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// <para>The consumption mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>CLUSTERING</b>: the clustering consumption mode</description></item>
                    /// <item><description><b>BROADCASTING</b>: the broadcasting consumption mode</description></item>
                    /// </list>
                    /// <para>For more information about consumption modes, see <a href="https://help.aliyun.com/document_detail/43163.html">Clustering consumption and broadcasting consumption</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CLUSTERING</para>
                    /// </summary>
                    [NameInMap("MessageModel")]
                    [Validation(Required=false)]
                    public string MessageModel { get; set; }

                    [NameInMap("Online")]
                    [Validation(Required=false)]
                    public string Online { get; set; }

                    /// <summary>
                    /// <para>The expression based on which consumers in the consumer group subscribe to the topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("SubString")]
                    [Validation(Required=false)]
                    public string SubString { get; set; }

                }

            }

            /// <summary>
            /// <para>The topic name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87B6207F-2908-42B5-A134-84956DCA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
