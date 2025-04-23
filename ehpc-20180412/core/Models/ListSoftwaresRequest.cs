// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListSoftwaresRequest : TeaModel {
        /// <summary>
        /// <para>The version of the E-HPC client.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87223.html">ListCurrentClientVersion</a> operation to query the E-HPC client version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("EhpcVersion")]
        [Validation(Required=false)]
        public string EhpcVersion { get; set; }

        /// <summary>
        /// <para>The image tag of the cluster.</para>
        /// <para>You can use the <a href="https://help.aliyun.com/document_detail/87213.html">ListImages</a> to query the image tag of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CentOS_7.2_64</para>
        /// </summary>
        [NameInMap("OsTag")]
        [Validation(Required=false)]
        public string OsTag { get; set; }

    }

}
