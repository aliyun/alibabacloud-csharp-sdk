// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateResourceLogRequest : TeaModel {
        /// <summary>
        /// <para>The Logstore of Log Service. For more information about how to query a Logstore, see <a href="https://help.aliyun.com/document_detail/426970.html">ListLogStores</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>access_log</para>
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        /// <summary>
        /// <para>The Log Service project that is associated with the resource group. For more information about how to query the project, see <a href="https://help.aliyun.com/document_detail/74955.html">ListProject</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-asdasdasd-sls</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
