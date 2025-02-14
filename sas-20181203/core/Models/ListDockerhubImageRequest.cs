// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListDockerhubImageRequest : TeaModel {
        /// <summary>
        /// <para>Image query condition, supports the format of <c>[namespace/]repoName[:version]</c>, where the conditions within <c>[]</c> are optional.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python:3.9</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
