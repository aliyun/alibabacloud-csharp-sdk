// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListDockerhubImageRequest : TeaModel {
        /// <summary>
        /// <para>The query condition for images. You can query images in the <c>[namespace/]repoName[:version]</c> format. Conditions in <c>[]</c> are optional.</para>
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
