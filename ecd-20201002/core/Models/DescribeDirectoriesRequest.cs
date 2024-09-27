// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeDirectoriesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54c17e1d-2d72-4b87-aa33-25f3b3f2****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public List<string> DirectoryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
