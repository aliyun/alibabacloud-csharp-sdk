// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreatePublishGroupTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the database for which the schema design is executed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        /// <summary>
        /// Indicates whether the database is a logical database.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// The ID of the ticket.
        /// 
        /// > : You can create a schema design ticket in the DMS console. For more information, see [Design schemas](https://help.aliyun.com/document_detail/69711.html). You can also create a schema design ticket by calling the [CreateOrder](https://help.aliyun.com/document_detail/144649.html) operation and obtain the ticket ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The time to execute the schema design ticket.
        /// </summary>
        [NameInMap("PlanTime")]
        [Validation(Required=false)]
        public string PlanTime { get; set; }

        /// <summary>
        /// The policy to execute the schema design ticket. Valid values:
        /// 
        /// *   IMMEDIATELY: immediately executes the schema design ticket.
        /// *   REGULARLY: executes the schema design ticket at a scheduled time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PublishStrategy")]
        [Validation(Required=false)]
        public string PublishStrategy { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > : To view the ID of the tenant, log on to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [Manage DMS tenants](https://help.aliyun.com/document_detail/181330.html).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
