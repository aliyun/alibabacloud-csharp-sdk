// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListApplicationEcuRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application whose ECUs you want to query. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e809****-43d7-4c6b-8e01-b0d9d1db****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the microservices namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou:***wei</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

    }

}
