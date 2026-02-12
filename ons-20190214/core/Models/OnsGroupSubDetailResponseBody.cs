// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsGroupSubDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsGroupSubDetailResponseBodyData Data { get; set; }
        public class OnsGroupSubDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the consumer group that you want to query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GID_test_group_id</para>
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

            /// <summary>
            /// <para>Indicates whether consumers in the group are online.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            [NameInMap("SubscriptionDataList")]
            [Validation(Required=false)]
            public OnsGroupSubDetailResponseBodyDataSubscriptionDataList SubscriptionDataList { get; set; }
            public class OnsGroupSubDetailResponseBodyDataSubscriptionDataList : TeaModel {
                [NameInMap("SubscriptionDataList")]
                [Validation(Required=false)]
                public List<OnsGroupSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList> SubscriptionDataList { get; set; }
                public class OnsGroupSubDetailResponseBodyDataSubscriptionDataListSubscriptionDataList : TeaModel {
                    [NameInMap("SubString")]
                    [Validation(Required=false)]
                    public string SubString { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3364E875-013B-442A-BC3C-C1A84DC6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
