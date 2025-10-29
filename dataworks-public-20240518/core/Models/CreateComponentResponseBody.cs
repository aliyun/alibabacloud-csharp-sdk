// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateComponentResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the dataset acceleration component. To obtain the component ID, see <a href="https://help.aliyun.com/document_detail/2979566.html">ListComponents</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123123123123</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public string ComponentId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>adssd****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
