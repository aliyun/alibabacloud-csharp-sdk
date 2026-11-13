// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QuerySensNodeInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the classification and grading node. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2746850.html">QuerySensClassification</a> operation, or by logging on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and going to the Data Security Guard page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ce67949-0810-400f-a24a-cc5ffafe1024</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The page number for paging. Valid values: integers starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging. Valid values: 10 to 1000. Recommended values: 10 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the sensitive field. You can obtain the name by logging on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and going to the Data Security Guard page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID card</para>
        /// </summary>
        [NameInMap("SensitiveName")]
        [Validation(Required=false)]
        public string SensitiveName { get; set; }

        /// <summary>
        /// <para>The ID of the classification and grading template. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2743948.html">QueryDefaultTemplate</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e1970541-6cf5-4d23-b101-d5b****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The tenant ID. To obtain the tenant ID, log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the Data Studio page, click the username in the upper-right corner, and then choose Menu &gt; User Info.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10241024</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The status of the sensitive field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Draft.</description></item>
        /// <item><description>1: Published.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
