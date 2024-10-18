// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class DesignateWorkersRequest : TeaModel {
        /// <summary>
        /// <para>The type of the machines to be designated. Valid values: 1 and 2. The value 1 specifies the worker type. The value 2 specifies the label type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DesignateType")]
        [Validation(Required=false)]
        public int? DesignateType { get; set; }

        /// <summary>
        /// <para>The application group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hxm.test</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>144153</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The designated <c>labels</c>. Specify the value of the parameter in a <c>JSON</c> string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;gray&quot;]</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The unique identifier (UID) of the namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a06d5ea-f576-4326-842c-fb14ea043d8d</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The source of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schedulerx</para>
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow a failover.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Transferable")]
        [Validation(Required=false)]
        public bool? Transferable { get; set; }

        /// <summary>
        /// <para>The designated machines. Specify the value of the parameter in a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;127.0.0.1&quot;,&quot;127.0.0.2&quot;]</para>
        /// </summary>
        [NameInMap("Workers")]
        [Validation(Required=false)]
        public string Workers { get; set; }

    }

}
