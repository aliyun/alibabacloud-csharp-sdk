// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class ModifyInstanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-123xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The reason for the update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>for test</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>User-defined configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataCoord:\n  segment:\n    maxSize: 1024</para>
        /// </summary>
        [NameInMap("UserConfig")]
        [Validation(Required=false)]
        public string UserConfig { get; set; }

    }

}
