// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ResourceOperation : TeaModel {
        /// <summary>
        /// <para>The ID of the creator of the resource change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1884692****</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The time when the resource change was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        /// <summary>
        /// <para>The time when the resource change ended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:02:00Z</para>
        /// </summary>
        [NameInMap("GmtEndTime")]
        [Validation(Required=false)]
        public string GmtEndTime { get; set; }

        /// <summary>
        /// <para>The time when the resource change was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-10T11:49:47Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The time when the resource change started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:01:00Z</para>
        /// </summary>
        [NameInMap("GmtStartTime")]
        [Validation(Required=false)]
        public string GmtStartTime { get; set; }

        /// <summary>
        /// <para>The object ID of the resource change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotaxxx</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The object type of the resource change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quota</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The description of the resource change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A user requests to change the Desired Capacity from 4 to 5.</para>
        /// </summary>
        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        /// <summary>
        /// <para>The resource change ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation-123</para>
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// <para>The details of the resource change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ScaleQuota&quot;:{&quot;Min&quot;:{&quot;NodeSpecs&quot;:[{&quot;Type&quot;:&quot;ecs.gn6i-c8g1.2xlarge&quot;,&quot;Count&quot;:20,&quot;IncludeNodes&quot;:[&quot;A&quot;,&quot;B&quot;,&quot;C&quot;],&quot;ExcludeNodes&quot;:[&quot;D&quot;]}]}}}</para>
        /// </summary>
        [NameInMap("OperationSpecJson")]
        [Validation(Required=false)]
        public string OperationSpecJson { get; set; }

        /// <summary>
        /// <para>The type of the resource change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ScaleQuota</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <para>The status of the resource change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Executing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
