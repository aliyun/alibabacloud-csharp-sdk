// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkListCdrObResponseBody : TeaModel {
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
        public ClinkListCdrObResponseBodyData Data { get; set; }
        public class ClinkListCdrObResponseBodyData : TeaModel {
            /// <summary>
            /// <para>[外呼记录列表] #外呼记录列表</para>
            /// </summary>
            [NameInMap("CdrOb")]
            [Validation(Required=false)]
            public List<ClinkListCdrObResponseBodyDataCdrOb> CdrOb { get; set; }
            public class ClinkListCdrObResponseBodyDataCdrOb : TeaModel {
                /// <summary>
                /// <para>转写记录标识 1：存在，0：不存在</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AsrRecord")]
                [Validation(Required=false)]
                public long? AsrRecord { get; set; }

                /// <summary>
                /// <para>通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>76</para>
                /// </summary>
                [NameInMap("BridgeDuration")]
                [Validation(Required=false)]
                public long? BridgeDuration { get; set; }

                /// <summary>
                /// <para>客户接听时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715326248</para>
                /// </summary>
                [NameInMap("BridgeTime")]
                [Validation(Required=false)]
                public long? BridgeTime { get; set; }

                /// <summary>
                /// <para>业务记录ID</para>
                /// </summary>
                [NameInMap("BusinessIds")]
                [Validation(Required=false)]
                public List<long?> BusinessIds { get; set; }

                /// <summary>
                /// <para>CallID</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>通话类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                /// <summary>
                /// <para>通话类型Key值</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CallTypeKey")]
                [Validation(Required=false)]
                public long? CallTypeKey { get; set; }

                /// <summary>
                /// <para>客户响铃时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>29</para>
                /// </summary>
                [NameInMap("CalleeRingingDuration")]
                [Validation(Required=false)]
                public long? CalleeRingingDuration { get; set; }

                /// <summary>
                /// <para>客户响铃时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715326251</para>
                /// </summary>
                [NameInMap("CalleeRingingTime")]
                [Validation(Required=false)]
                public long? CalleeRingingTime { get; set; }

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
                /// <para>座席工号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>客户地区，省份/城市</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("CustomerArea")]
                [Validation(Required=false)]
                public string CustomerArea { get; set; }

                /// <summary>
                /// <para>客户号码区号</para>
                /// 
                /// <b>Example:</b>
                /// <para>010</para>
                /// </summary>
                [NameInMap("CustomerAreaCode")]
                [Validation(Required=false)]
                public string CustomerAreaCode { get; set; }

                /// <summary>
                /// <para>客户号码城市</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("CustomerCity")]
                [Validation(Required=false)]
                public string CustomerCity { get; set; }

                /// <summary>
                /// <para>客户号码</para>
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
                /// <para>追加客户邮编</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CustomerPostCode")]
                [Validation(Required=false)]
                public string CustomerPostCode { get; set; }

                /// <summary>
                /// <para>客户号码省份</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("CustomerProvince")]
                [Validation(Required=false)]
                public string CustomerProvince { get; set; }

                /// <summary>
                /// <para>客户VIP标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CustomerVip")]
                [Validation(Required=false)]
                public long? CustomerVip { get; set; }

                /// <summary>
                /// <para>结束时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715326248</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>企业号</para>
                /// 
                /// <b>Example:</b>
                /// <para>8004970</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public long? EnterpriseId { get; set; }

                /// <summary>
                /// <para>是否邀评</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Evaluation")]
                [Validation(Required=false)]
                public string Evaluation { get; set; }

                /// <summary>
                /// <para>是否存在业务记录</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ExistBusiness")]
                [Validation(Required=false)]
                public long? ExistBusiness { get; set; }

                /// <summary>
                /// <para>是否存在客户资料</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ExistCustomer")]
                [Validation(Required=false)]
                public bool? ExistCustomer { get; set; }

                /// <summary>
                /// <para>是否存在工单</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ExistTicket")]
                [Validation(Required=false)]
                public long? ExistTicket { get; set; }

                /// <summary>
                /// <para>满意度评价</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("InvestigationKeys")]
                [Validation(Required=false)]
                public long? InvestigationKeys { get; set; }

                /// <summary>
                /// <para>外显号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("LeftClid")]
                [Validation(Required=false)]
                public string LeftClid { get; set; }

                /// <summary>
                /// <para>外显号码归属地区，省份/城市</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("LeftClidArea")]
                [Validation(Required=false)]
                public string LeftClidArea { get; set; }

                /// <summary>
                /// <para>外显号码归属城市</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("LeftClidCity")]
                [Validation(Required=false)]
                public string LeftClidCity { get; set; }

                /// <summary>
                /// <para>外显号码归属省份</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("LeftClidProvince")]
                [Validation(Required=false)]
                public string LeftClidProvince { get; set; }

                /// <summary>
                /// <para>通话ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>medias_1-171532xxxx.53</para>
                /// </summary>
                [NameInMap("MainUniqueId")]
                [Validation(Required=false)]
                public string MainUniqueId { get; set; }

                /// <summary>
                /// <para>备注</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MarkData")]
                [Validation(Required=false)]
                public string MarkData { get; set; }

                /// <summary>
                /// <para>呼叫结果</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("ObSipCause")]
                [Validation(Required=false)]
                public string ObSipCause { get; set; }

                /// <summary>
                /// <para>被叫状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("ObSipCauseRaw")]
                [Validation(Required=false)]
                public string ObSipCauseRaw { get; set; }

                /// <summary>
                /// <para>外呼等待时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("ObWaitDuration")]
                [Validation(Required=false)]
                public long? ObWaitDuration { get; set; }

                /// <summary>
                /// <para>挂断方</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("OnHookSource")]
                [Validation(Required=false)]
                public string OnHookSource { get; set; }

                /// <summary>
                /// <para>响铃前等待时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PreRingWaitDuration")]
                [Validation(Required=false)]
                public long? PreRingWaitDuration { get; set; }

                /// <summary>
                /// <para>录音文件</para>
                /// 
                /// <b>Example:</b>
                /// <para>RecordFile</para>
                /// </summary>
                [NameInMap("RecordFile")]
                [Validation(Required=false)]
                public string RecordFile { get; set; }

                /// <summary>
                /// <para>通话唯一ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("RequestUniqueId")]
                [Validation(Required=false)]
                public string RequestUniqueId { get; set; }

                /// <summary>
                /// <para>RtcUid</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("RtcUid")]
                [Validation(Required=false)]
                public string RtcUid { get; set; }

                /// <summary>
                /// <para>开始时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715326248</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>接听状态值</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <para>接听状态描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <para>通话标签</para>
                /// </summary>
                [NameInMap("TagNames")]
                [Validation(Required=false)]
                public List<string> TagNames { get; set; }

                /// <summary>
                /// <para>外呼任务id</para>
                /// 
                /// <b>Example:</b>
                /// <para>85</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>外呼任务详情id</para>
                /// 
                /// <b>Example:</b>
                /// <para>83</para>
                /// </summary>
                [NameInMap("TaskInventoryId")]
                [Validation(Required=false)]
                public long? TaskInventoryId { get; set; }

                /// <summary>
                /// <para>外呼任务名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>TaskName</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>工单id</para>
                /// </summary>
                [NameInMap("TicketIds")]
                [Validation(Required=false)]
                public List<long?> TicketIds { get; set; }

                /// <summary>
                /// <para>总时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>27</para>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public long? TotalDuration { get; set; }

                /// <summary>
                /// <para>中继组号</para>
                /// 
                /// <b>Example:</b>
                /// <para>10088</para>
                /// </summary>
                [NameInMap("TrunkGroupKey")]
                [Validation(Required=false)]
                public string TrunkGroupKey { get; set; }

                /// <summary>
                /// <para>座席接起时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715326251</para>
                /// </summary>
                [NameInMap("UpTime")]
                [Validation(Required=false)]
                public long? UpTime { get; set; }

                /// <summary>
                /// <para>WebRTCCallID</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("WebrtcCallId")]
                [Validation(Required=false)]
                public string WebrtcCallId { get; set; }

                /// <summary>
                /// <para>虚拟号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Xnumber")]
                [Validation(Required=false)]
                public string Xnumber { get; set; }

                /// <summary>
                /// <para>虚拟号码归属地区，省份/城市</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("XnumberArea")]
                [Validation(Required=false)]
                public string XnumberArea { get; set; }

                /// <summary>
                /// <para>虚拟号码归属城市</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("XnumberCity")]
                [Validation(Required=false)]
                public string XnumberCity { get; set; }

                /// <summary>
                /// <para>虚拟号码归属省份</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("XnumberProvince")]
                [Validation(Required=false)]
                public string XnumberProvince { get; set; }

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
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>滚动查询ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>ScrollId</para>
            /// </summary>
            [NameInMap("ScrollId")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            /// <summary>
            /// <para>总条数</para>
            /// 
            /// <b>Example:</b>
            /// <para>31</para>
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
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
