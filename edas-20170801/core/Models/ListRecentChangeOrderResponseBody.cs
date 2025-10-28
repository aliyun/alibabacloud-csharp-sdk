// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListRecentChangeOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about change processes.</para>
        /// </summary>
        [NameInMap("ChangeOrderList")]
        [Validation(Required=false)]
        public ListRecentChangeOrderResponseBodyChangeOrderList ChangeOrderList { get; set; }
        public class ListRecentChangeOrderResponseBodyChangeOrderList : TeaModel {
            [NameInMap("ChangeOrder")]
            [Validation(Required=false)]
            public List<ListRecentChangeOrderResponseBodyChangeOrderListChangeOrder> ChangeOrder { get; set; }
            public class ListRecentChangeOrderResponseBodyChangeOrderListChangeOrder : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3616cdca-4f92-4413-<b><b>-</b></b>********</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The number of batches for the change. Valid values: 1 to 5.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BatchCount")]
                [Validation(Required=false)]
                public int? BatchCount { get; set; }

                /// <summary>
                /// <para>The way in which the next batch is triggered during a phased release. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Automatic</description></item>
                /// <item><description>Manual</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Automatic</para>
                /// </summary>
                [NameInMap("BatchType")]
                [Validation(Required=false)]
                public string BatchType { get; set; }

                /// <summary>
                /// <para>The description of the change process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Version: 2020-05-14 20:02:33 | Deployment Package: hsf-pandora-boot-provider-1.0.jar | Deploy to: all groups</para>
                /// </summary>
                [NameInMap("ChangeOrderDescription")]
                [Validation(Required=false)]
                public string ChangeOrderDescription { get; set; }

                /// <summary>
                /// <para>The unique ID of the change process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1074f3e2-e974-4a0e-<b><b>-</b></b>********</para>
                /// </summary>
                [NameInMap("ChangeOrderId")]
                [Validation(Required=false)]
                public string ChangeOrderId { get; set; }

                /// <summary>
                /// <para>The type of the change process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Application Scale Out</para>
                /// </summary>
                [NameInMap("CoType")]
                [Validation(Required=false)]
                public string CoType { get; set; }

                /// <summary>
                /// <para>The type of the change process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CoDeploy</para>
                /// </summary>
                [NameInMap("CoTypeCode")]
                [Validation(Required=false)]
                public string CoTypeCode { get; set; }

                /// <summary>
                /// <para>The time when the change process was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-13 14:23:46</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The user who created the change process.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:edas_test1@aliyun-test.com">edas_test1@aliyun-test.com</a></para>
                /// </summary>
                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public string CreateUserId { get; set; }

                /// <summary>
                /// <para>The time when the change process ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-13 14:24:02</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the application instance group on which the change was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8123db90-880f-486f-<b><b>-</b></b>********</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The source of the change. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>console: the Enterprise Distributed Application Service (EDAS) console</description></item>
                /// <item><description>pop: the POP API or tool</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pop</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The state of the change process. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: ready to start execution</description></item>
                /// <item><description>1: in progress</description></item>
                /// <item><description>2: successful</description></item>
                /// <item><description>3: failed</description></item>
                /// <item><description>6: terminated</description></item>
                /// <item><description>8: waiting for manual confirmation (You can see the state when you manually confirm the execution of the next batch of the change.)</description></item>
                /// <item><description>9: waiting for automatic execution</description></item>
                /// <item><description>10: failed due to a system error</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The ID of the user who created the change process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1432536****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D16979DC-4D42-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
