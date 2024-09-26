// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QuerySensNodeInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data category. You can call the <a href="https://help.aliyun.com/document_detail/2746850.html">QuerySensClassification</a> operation or log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Data Security Guard page to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ce67949-0810-400f-a24a-cc5ffafe1024</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 10 to 1000. The recommended number of entries per page ranges from 10 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the sensitive field. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Data Security Guard page to obtain the name.</para>
        /// </summary>
        [NameInMap("SensitiveName")]
        [Validation(Required=false)]
        public string SensitiveName { get; set; }

        /// <summary>
        /// <para>The ID of the data category and data sensitivity level template. You can call the <a href="https://help.aliyun.com/document_detail/2743948.html">QueryDefaultTemplate</a> operation to obtain the template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e1970541-6cf5-4d23-b101-d5b66f6e1024</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The tenant ID. To obtain the tenant ID, perform the following steps: Log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. Find your workspace and go to the DataStudio page. On the DataStudio page, click the logon username in the upper-right corner and click User Info in the Menu section.</para>
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
        /// <item><description>0: draft</description></item>
        /// <item><description>1: published</description></item>
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
