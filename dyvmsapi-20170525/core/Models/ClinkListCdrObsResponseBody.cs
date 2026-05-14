// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkListCdrObsResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClinkListCdrObsResponseBodyData Data { get; set; }
        public class ClinkListCdrObsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>[外呼通话记录列表] #外呼通话记录列表</para>
            /// </summary>
            [NameInMap("CdrObs")]
            [Validation(Required=false)]
            public List<ClinkListCdrObsResponseBodyDataCdrObs> CdrObs { get; set; }
            public class ClinkListCdrObsResponseBodyDataCdrObs : TeaModel {
                /// <summary>
                /// <para>接通时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>87</para>
                /// </summary>
                [NameInMap("BridgeDuration")]
                [Validation(Required=false)]
                public long? BridgeDuration { get; set; }

                /// <summary>
                /// <para>接通时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("BridgeTime")]
                [Validation(Required=false)]
                public long? BridgeTime { get; set; }

                /// <summary>
                /// <para>通话记录ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>CallId</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>外呼类型，预览外呼、预测外呼、直接外呼</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>ClientName</para>
                /// </summary>
                [NameInMap("ClientName")]
                [Validation(Required=false)]
                public string ClientName { get; set; }

                /// <summary>
                /// <para>座席电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ClientNumber")]
                [Validation(Required=false)]
                public string ClientNumber { get; set; }

                /// <summary>
                /// <para>座席响铃时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("ClientRingingTime")]
                [Validation(Required=false)]
                public long? ClientRingingTime { get; set; }

                /// <summary>
                /// <para>座席号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>客户城市</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("CustomerCity")]
                [Validation(Required=false)]
                public string CustomerCity { get; set; }

                /// <summary>
                /// <para>客户号码，带区号</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CustomerNumber")]
                [Validation(Required=false)]
                public string CustomerNumber { get; set; }

                /// <summary>
                /// <para>客户号码加密串</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CustomerNumberEncrypt")]
                [Validation(Required=false)]
                public string CustomerNumberEncrypt { get; set; }

                /// <summary>
                /// <para>客户省份</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("CustomerProvince")]
                [Validation(Required=false)]
                public string CustomerProvince { get; set; }

                /// <summary>
                /// <para>客户响铃时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("CustomerRingingTime")]
                [Validation(Required=false)]
                public long? CustomerRingingTime { get; set; }

                /// <summary>
                /// <para>挂机方</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("EndReason")]
                [Validation(Required=false)]
                public string EndReason { get; set; }

                /// <summary>
                /// <para>结束时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>是否邀评</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Evaluation")]
                [Validation(Required=false)]
                public long? Evaluation { get; set; }

                /// <summary>
                /// <para>热线号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hotline</para>
                /// </summary>
                [NameInMap("Hotline")]
                [Validation(Required=false)]
                public string Hotline { get; set; }

                /// <summary>
                /// <para>IVR名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>IvrName</para>
                /// </summary>
                [NameInMap("IvrName")]
                [Validation(Required=false)]
                public string IvrName { get; set; }

                /// <summary>
                /// <para>标记</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Mark")]
                [Validation(Required=false)]
                public long? Mark { get; set; }

                /// <summary>
                /// <para>备注</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("MarkData")]
                [Validation(Required=false)]
                public string MarkData { get; set; }

                /// <summary>
                /// <para>来电队列名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>2222</para>
                /// </summary>
                [NameInMap("Qname")]
                [Validation(Required=false)]
                public string Qname { get; set; }

                /// <summary>
                /// <para>来电队列号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1212</para>
                /// </summary>
                [NameInMap("Qno")]
                [Validation(Required=false)]
                public string Qno { get; set; }

                /// <summary>
                /// <para>队列及时应答</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("QueueAnswerInTime")]
                [Validation(Required=false)]
                public long? QueueAnswerInTime { get; set; }

                /// <summary>
                /// <para>录音文件名</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RecordFile")]
                [Validation(Required=false)]
                public string RecordFile { get; set; }

                /// <summary>
                /// <para>呼叫结果</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("SipCause")]
                [Validation(Required=false)]
                public string SipCause { get; set; }

                /// <summary>
                /// <para>开始时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1775024775</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>接听状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>接听状态映射</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                /// <summary>
                /// <para>展示通话标签详情,当请求参数fields中包含tagNames时返回</para>
                /// </summary>
                [NameInMap("TagNames")]
                [Validation(Required=false)]
                public List<string> TagNames { get; set; }

                /// <summary>
                /// <para>标签</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                /// <summary>
                /// <para>总时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>81</para>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public long? TotalDuration { get; set; }

                /// <summary>
                /// <para>通话记录唯一标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>UniqueId</para>
                /// </summary>
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }

                /// <summary>
                /// <para>虚拟号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Xnumber")]
                [Validation(Required=false)]
                public string Xnumber { get; set; }

            }

            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

            /// <summary>
            /// <para>当前页码</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>一页展示条数</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>总条数</para>
            /// 
            /// <b>Example:</b>
            /// <para>49</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4B52E871-0F7C-59FC-9C7E-94B550953BA9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
