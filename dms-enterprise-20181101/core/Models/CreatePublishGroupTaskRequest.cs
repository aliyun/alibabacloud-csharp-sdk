// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreatePublishGroupTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the database for which the schema design is executed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        /// <summary>
        /// <para>Indicates whether the database is a logical database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// <para>The ID of the ticket.</para>
        /// <remarks>
        /// <para>: You can create a schema design ticket in the DMS console. For more information, see <a href="https://help.aliyun.com/document_detail/69711.html">Design schemas</a>. You can also create a schema design ticket by calling the <a href="https://help.aliyun.com/document_detail/144649.html">CreateOrder</a> operation and obtain the ticket ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>142435</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The time to execute the schema design ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-10 00:00:00</para>
        /// </summary>
        [NameInMap("PlanTime")]
        [Validation(Required=false)]
        public string PlanTime { get; set; }

        /// <summary>
        /// <para>The policy to execute the schema design ticket. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IMMEDIATELY: immediately executes the schema design ticket.</description></item>
        /// <item><description>REGULARLY: executes the schema design ticket at a scheduled time.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMMEDIATELY</para>
        /// </summary>
        [NameInMap("PublishStrategy")]
        [Validation(Required=false)]
        public string PublishStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>: To view the ID of the tenant, log on to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
