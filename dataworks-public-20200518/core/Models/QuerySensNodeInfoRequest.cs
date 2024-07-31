// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QuerySensNodeInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the data category. You can call the [QuerySensClassification](https://help.aliyun.com/document_detail/2746850.html) operation or log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Data Security Guard page to obtain the ID.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 10 to 1000. The recommended number of entries per page ranges from 10 to 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the sensitive field. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Data Security Guard page to obtain the name.
        /// </summary>
        [NameInMap("SensitiveName")]
        [Validation(Required=false)]
        public string SensitiveName { get; set; }

        /// <summary>
        /// The ID of the data category and data sensitivity level template. You can call the [QueryDefaultTemplate](https://help.aliyun.com/document_detail/2743948.html) operation to obtain the template ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The tenant ID. To obtain the tenant ID, perform the following steps: Log on to the [DataWorks console](https://workbench.data.aliyun.com/console). Find your workspace and go to the DataStudio page. On the DataStudio page, click the logon username in the upper-right corner and click User Info in the Menu section.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The status of the sensitive field. Valid values:
        /// 
        /// *   0: draft
        /// *   1: published
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
