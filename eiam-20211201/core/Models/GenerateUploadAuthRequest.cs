// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GenerateUploadAuthRequest : TeaModel {
        /// <summary>
        /// <para>IDaaS EIAM的实例id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_111ccc11xxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>文件用途</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_import</para>
        /// </summary>
        [NameInMap("Purpose")]
        [Validation(Required=false)]
        public string Purpose { get; set; }

        /// <summary>
        /// <para>文件类型，目前只支持image,最大1M</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
