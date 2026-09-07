// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteTraceAppRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application that you want to delete. You can call the SearchTraceAppByName operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/130676.html">SearchTraceAppByName</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5406**</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The reason(s) to delete application.</para>
        /// </summary>
        [NameInMap("DeleteReason")]
        [Validation(Required=false)]
        public DeleteTraceAppRequestDeleteReason DeleteReason { get; set; }
        public class DeleteTraceAppRequestDeleteReason : TeaModel {
            /// <summary>
            /// <para>Reasons Ids.</para>
            /// </summary>
            [NameInMap("ReasonIds")]
            [Validation(Required=false)]
            public List<DeleteTraceAppRequestDeleteReasonReasonIds> ReasonIds { get; set; }
            public class DeleteTraceAppRequestDeleteReasonReasonIds : TeaModel {
                /// <summary>
                /// <para>The ID of the reason for deletion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>A description of the reason for removal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>删除理由描述，ID和Name的对应关系：
                /// &quot;id&quot;:0,&quot;name&quot;:&quot;功能不完善，无法定位到问题根本原因。&quot;
                /// &quot;id&quot;:1,&quot;name&quot;:&quot;Agent不稳定，影响应用运行。&quot;
                /// &quot;id&quot;:2,&quot;name&quot;:&quot;服务不稳定，经常打不开界面。&quot;
                /// &quot;id&quot;:3,&quot;name&quot;:&quot;报警相关问题。&quot;
                /// &quot;id&quot;:4,&quot;name&quot;:&quot;价格太贵&quot;
                /// &quot;id&quot;:5,&quot;name&quot;:&quot;其他原因&quot;</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Additional remarks when none of the reasons for removal provided are met.</para>
            /// 
            /// <b>Example:</b>
            /// <para>业务场景覆盖不全</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>The PID of the application. For more information about how to query the PID, see <a href="https://www.alibabacloud.com/help/zh/doc-detail/186100.htm?spm=a2cdw.13409063.0.0.7a72281f0bkTfx#title-imy-7gj-qhr">QueryMetricByPage</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9w0sc5gxxz@edcsd447c2f****</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the application is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of the application that you want to delete. You can call the SearchTraceAppByName operation to query the application type. For more information, see <a href="https://help.aliyun.com/document_detail/130676.html">SearchTraceAppByName</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>TRACE</c>: Application Monitoring</description></item>
        /// <item><description><c>RETCODE</c>: frontend monitoring</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TRACE</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
