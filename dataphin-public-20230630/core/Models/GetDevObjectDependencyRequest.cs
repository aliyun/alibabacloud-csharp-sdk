// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDevObjectDependencyRequest : TeaModel {
        /// <summary>
        /// <para>Development object source.</para>
        /// <list type="bullet">
        /// <item><description>BLACK_BOX: Logical table</description></item>
        /// <item><description>DATA_PROCESS: Compute task</description></item>
        /// <item><description>PIPELINE: Integration task</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATA_PROCESS</para>
        /// </summary>
        [NameInMap("ObjectFrom")]
        [Validation(Required=false)]
        public string ObjectFrom { get; set; }

        /// <summary>
        /// <para>Object ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7026498387616064</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>Development object type.</para>
        /// <list type="bullet">
        /// <item><description>FILE_ID: Task FileId</description></item>
        /// <item><description>MODEL_ID: Logical table</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7026498387616064</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>Tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>Project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7021037162911616L</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
