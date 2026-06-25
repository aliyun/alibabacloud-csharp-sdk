// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListChangeOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or the POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: Success.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: Redirect.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: Request error.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: Server error.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the change orders.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListChangeOrdersResponseBodyData Data { get; set; }
        public class ListChangeOrdersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of change orders.</para>
            /// </summary>
            [NameInMap("ChangeOrderList")]
            [Validation(Required=false)]
            public List<ListChangeOrdersResponseBodyDataChangeOrderList> ChangeOrderList { get; set; }
            public class ListChangeOrdersResponseBodyDataChangeOrderList : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>164341c-9708-4967-b3ec-24933767****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The number of batches.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BatchCount")]
                [Validation(Required=false)]
                public int? BatchCount { get; set; }

                /// <summary>
                /// <para>The batch type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>auto</b>: Automatic.</para>
                /// </description></item>
                /// <item><description><para><b>manual</b>: Manual.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>auto</para>
                /// </summary>
                [NameInMap("BatchType")]
                [Validation(Required=false)]
                public string BatchType { get; set; }

                /// <summary>
                /// <para>The change order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7fa5c0-9ebb-4bb4-b383-1f885447****</para>
                /// </summary>
                [NameInMap("ChangeOrderId")]
                [Validation(Required=false)]
                public string ChangeOrderId { get; set; }

                /// <summary>
                /// <para>The description of the change type code (<b>CoTypeCode</b>).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Create application</para>
                /// </summary>
                [NameInMap("CoType")]
                [Validation(Required=false)]
                public string CoType { get; set; }

                /// <summary>
                /// <para>The code of the change type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>CoBindSlb</b>: Bind an SLB instance.</para>
                /// </description></item>
                /// <item><description><para><b>CoUnbindSlb</b>: Unbind an SLB instance.</para>
                /// </description></item>
                /// <item><description><para><b>CoCreateApp</b>: Create an application.</para>
                /// </description></item>
                /// <item><description><para><b>CoDeleteApp</b>: Delete an application.</para>
                /// </description></item>
                /// <item><description><para><b>CoDeploy</b>: Deploy an application.</para>
                /// </description></item>
                /// <item><description><para><b>CoRestartApplication</b>: Restart an application.</para>
                /// </description></item>
                /// <item><description><para><b>CoRollback</b>: Roll back an application.</para>
                /// </description></item>
                /// <item><description><para><b>CoScaleIn</b>: Scale in an application.</para>
                /// </description></item>
                /// <item><description><para><b>CoScaleOut</b>: Scale out an application.</para>
                /// </description></item>
                /// <item><description><para><b>CoStartApplication</b>: Start an application.</para>
                /// </description></item>
                /// <item><description><para><b>CoStopApplication</b>: Stop an application.</para>
                /// </description></item>
                /// <item><description><para><b>CoRescaleApplicationVertically</b>: Change the instance type.</para>
                /// </description></item>
                /// <item><description><para><b>CoDeployHistroy</b>: Roll back to a previous version.</para>
                /// </description></item>
                /// <item><description><para><b>CoBindNas</b>: Bind a NAS file system.</para>
                /// </description></item>
                /// <item><description><para><b>CoUnbindNas</b>: Unbind a NAS file system.</para>
                /// </description></item>
                /// <item><description><para><b>CoBatchStartApplication</b>: Start multiple applications.</para>
                /// </description></item>
                /// <item><description><para><b>CoBatchStopApplication</b>: Stop multiple applications.</para>
                /// </description></item>
                /// <item><description><para><b>CoRestartInstances</b>: Restart instances.</para>
                /// </description></item>
                /// <item><description><para><b>CoDeleteInstances</b>: Delete instances.</para>
                /// </description></item>
                /// <item><description><para><b>CoScaleInAppWithInstances</b>: Scale in an application by specifying instances.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CoCreateApp</para>
                /// </summary>
                [NameInMap("CoTypeCode")]
                [Validation(Required=false)]
                public string CoTypeCode { get; set; }

                /// <summary>
                /// <para>The time the change order was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-07-11 15:54:49</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the user who created the change order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sae-beta-test</para>
                /// </summary>
                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public string CreateUserId { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Version: 1.0 | image name: nginx</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time the change order was completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-07-11 20:12:58</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c9ecd2-cf6c-46c3-9f20-525de202****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The source of the change order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>console</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The status of the change order. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: Preparing.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: In progress.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Succeeded.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: Failed.</para>
                /// </description></item>
                /// <item><description><para><b>6</b>: Aborted.</para>
                /// </description></item>
                /// <item><description><para><b>8</b>: Paused for manual confirmation.</para>
                /// </description></item>
                /// <item><description><para><b>9</b>: Paused for automatic confirmation.</para>
                /// </description></item>
                /// <item><description><para><b>10</b>: Failed due to a system exception.</para>
                /// </description></item>
                /// <item><description><para><b>11</b>: Pending approval.</para>
                /// </description></item>
                /// <item><description><para><b>12</b>: Approved and pending execution.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sae-beta-test</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of change orders.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not returned on successful requests.</para>
        /// </description></item>
        /// <item><description><para>Returned if the request fails. For more information, see the <b>error code</b> list in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Additional information about the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65E1F-43BA-4D0C-8E61-E4D1337F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the list of change orders was retrieved. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The list was retrieved.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The list could not be retrieved.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID used to query request details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bb6f815638568884597879d****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
