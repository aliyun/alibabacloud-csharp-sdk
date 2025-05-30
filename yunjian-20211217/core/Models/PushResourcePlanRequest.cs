// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yunjian20211217.Models
{
    public class PushResourcePlanRequest : TeaModel {
        [NameInMap("bufferCnt")]
        [Validation(Required=false)]
        public long? BufferCnt { get; set; }

        [NameInMap("demandCount")]
        [Validation(Required=false)]
        public long? DemandCount { get; set; }

        [NameInMap("demandId")]
        [Validation(Required=false)]
        public string DemandId { get; set; }

        [NameInMap("methodList")]
        [Validation(Required=false)]
        public List<PushResourcePlanRequestMethodList> MethodList { get; set; }
        public class PushResourcePlanRequestMethodList : TeaModel {
            [NameInMap("azone")]
            [Validation(Required=false)]
            public string Azone { get; set; }

            [NameInMap("bufferCnt")]
            [Validation(Required=false)]
            public long? BufferCnt { get; set; }

            [NameInMap("cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("convertHostCnt")]
            [Validation(Required=false)]
            public long? ConvertHostCnt { get; set; }

            [NameInMap("convertHostType")]
            [Validation(Required=false)]
            public string ConvertHostType { get; set; }

            [NameInMap("dataList")]
            [Validation(Required=false)]
            public List<PushResourcePlanRequestMethodListDataList> DataList { get; set; }
            public class PushResourcePlanRequestMethodListDataList : TeaModel {
                [NameInMap("classZone")]
                [Validation(Required=false)]
                public string ClassZone { get; set; }

                [NameInMap("convertHostType")]
                [Validation(Required=false)]
                public string ConvertHostType { get; set; }

                [NameInMap("logicZone")]
                [Validation(Required=false)]
                public string LogicZone { get; set; }

                [NameInMap("netArch")]
                [Validation(Required=false)]
                public string NetArch { get; set; }

                [NameInMap("nic")]
                [Validation(Required=false)]
                public string Nic { get; set; }

                [NameInMap("product3")]
                [Validation(Required=false)]
                public string Product3 { get; set; }

                [NameInMap("safeZone")]
                [Validation(Required=false)]
                public string SafeZone { get; set; }

                [NameInMap("scenario")]
                [Validation(Required=false)]
                public string Scenario { get; set; }

                [NameInMap("supplyAmount")]
                [Validation(Required=false)]
                public long? SupplyAmount { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("supplyDate")]
                [Validation(Required=false)]
                public string SupplyDate { get; set; }

                [NameInMap("supplyType")]
                [Validation(Required=false)]
                public long? SupplyType { get; set; }

                [NameInMap("supplyVmAmount")]
                [Validation(Required=false)]
                public int? SupplyVmAmount { get; set; }

            }

            [NameInMap("denamdCount")]
            [Validation(Required=false)]
            public long? DenamdCount { get; set; }

            [NameInMap("gapCnt")]
            [Validation(Required=false)]
            public long? GapCnt { get; set; }

            [NameInMap("promiseDate")]
            [Validation(Required=false)]
            public string PromiseDate { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("resourceMethodId")]
            [Validation(Required=false)]
            public long? ResourceMethodId { get; set; }

            [NameInMap("roomCode")]
            [Validation(Required=false)]
            public string RoomCode { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("requireCnt")]
        [Validation(Required=false)]
        public long? RequireCnt { get; set; }

        [NameInMap("subDemandId")]
        [Validation(Required=false)]
        public string SubDemandId { get; set; }

    }

}
