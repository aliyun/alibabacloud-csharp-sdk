// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteServiceInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the container in which to restart the process. This parameter is valid only when \<c>SoftRestart\\</c> is set to \<c>true\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>worker0</para>
        /// </summary>
        [NameInMap("Container")]
        [Validation(Required=false)]
        public string Container { get; set; }

        /// <summary>
        /// <para>The instances to restart. Separate multiple instance names with a comma (,). For more information, see <a href="https://help.aliyun.com/document_detail/412108.html">ListServiceInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo-rdsbxxxx,foo-rdsaxxxx</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public string InstanceList { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is a replica.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsReplica")]
        [Validation(Required=false)]
        public bool? IsReplica { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart only the container process without rebuilding the instance. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SoftRestart")]
        [Validation(Required=false)]
        public bool? SoftRestart { get; set; }

    }

}
