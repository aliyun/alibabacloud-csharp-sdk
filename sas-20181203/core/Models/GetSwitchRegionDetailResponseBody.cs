// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSwitchRegionDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSwitchRegionDetailResponseBodyData Data { get; set; }
        public class GetSwitchRegionDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the authorization operation was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1692858597000</para>
            /// </summary>
            [NameInMap("GmtIsAgreeModified")]
            [Validation(Required=false)]
            public long? GmtIsAgreeModified { get; set; }

            /// <summary>
            /// <para>The notification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1692858597000</para>
            /// </summary>
            [NameInMap("GmtNoticed")]
            [Validation(Required=false)]
            public long? GmtNoticed { get; set; }

            /// <summary>
            /// <para>Indicates whether the migration is agreed to.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAgree")]
            [Validation(Required=false)]
            public string IsAgree { get; set; }

            /// <summary>
            /// <para>Indicates whether the notification has been sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YES</para>
            /// </summary>
            [NameInMap("IsNoticed")]
            [Validation(Required=false)]
            public string IsNoticed { get; set; }

            /// <summary>
            /// <para>Indicates whether a pop-up notification needs to be displayed to the user.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: A pop-up notification needs to be displayed.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No pop-up notification needs to be displayed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedNotice")]
            [Validation(Required=false)]
            public bool? NeedNotice { get; set; }

            /// <summary>
            /// <para>Indicates whether a switchover to the new console is required.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: A switchover to the new console is required.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The legacy console is still in use.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedSwitch")]
            [Validation(Required=false)]
            public bool? NeedSwitch { get; set; }

            /// <summary>
            /// <para>The switchover status of the region.</para>
            /// </summary>
            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public List<GetSwitchRegionDetailResponseBodyDataRegionStatus> RegionStatus { get; set; }
            public class GetSwitchRegionDetailResponseBodyDataRegionStatus : TeaModel {
                /// <summary>
                /// <para>The number of ECS instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>27</para>
                /// </summary>
                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public int? EcsCount { get; set; }

                /// <summary>
                /// <para>The planned migration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1692858597000</para>
                /// </summary>
                [NameInMap("GmtPlanSwitchTime")]
                [Validation(Required=false)]
                public long? GmtPlanSwitchTime { get; set; }

                /// <summary>
                /// <para>The region where the server resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-east-1</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The migration status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: waiting for migration</description></item>
                /// <item><description><b>1</b>: switchover succeeded.</description></item>
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

        /// <summary>
        /// <para>The ID of the request. The China Chinese mainland generates a unique identifier for each request, which can be used for troubleshooting and diagnostics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30CBF632-109F-596F-97F2-451C8B2A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
