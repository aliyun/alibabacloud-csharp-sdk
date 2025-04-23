// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class InstallSoftwareRequest : TeaModel {
        /// <summary>
        /// <para>The name of the software that you want to install.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87216.html">ListSoftwares</a> operation to query the software that can be installed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABYSS_2.1.5</para>
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public string Application { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-jeJki6****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
