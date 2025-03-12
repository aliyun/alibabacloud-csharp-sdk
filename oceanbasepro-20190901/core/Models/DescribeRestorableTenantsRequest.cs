// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeRestorableTenantsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the OceanBase cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the target cluster is online. <b>Note</b> This parameter is used for compatibility with earlier versions and can be left empty. When left empty, it specifies negation for the value of <c>isRemote</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsOnline")]
        [Validation(Required=false)]
        public bool? IsOnline { get; set; }

        /// <summary>
        /// <para>This parameter is provided for compatibility with earlier versions and can be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsRemote")]
        [Validation(Required=false)]
        public bool? IsRemote { get; set; }

        /// <summary>
        /// <para>The backup method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>native_logical</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The restore method. This parameter is required when <c>IsRemote</c> is set to <c>true</c>, and is optional otherwise.</para>
        /// 
        /// <b>Example:</b>
        /// <para>from_time_point</para>
        /// </summary>
        [NameInMap("RestoreMode")]
        [Validation(Required=false)]
        public string RestoreMode { get; set; }

        /// <summary>
        /// <para>The type of the restore object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tenant</para>
        /// </summary>
        [NameInMap("RestoreObjectType")]
        [Validation(Required=false)]
        public string RestoreObjectType { get; set; }

        /// <summary>
        /// <para>The ID of the backup set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bak-xxxxx</para>
        /// </summary>
        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

    }

}
