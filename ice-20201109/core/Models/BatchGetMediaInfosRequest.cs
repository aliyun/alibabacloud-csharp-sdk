// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class BatchGetMediaInfosRequest : TeaModel {
        /// <summary>
        /// <para>The additional information that you want to query about the media assets. By default, only BasicInfo is returned. The following additional information can be queried:</para>
        /// <para>\- FileInfo</para>
        /// <para>\- DynamicMetaData</para>
        /// 
        /// <b>Example:</b>
        /// <para>FileInfo,DynamicMetaData</para>
        /// </summary>
        [NameInMap("AdditionType")]
        [Validation(Required=false)]
        public string AdditionType { get; set; }

        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// <para>The IDs of the media assets that you want to query. Separate the IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>b48fb04483915d4f2cd8</b></b></b>,<b><b><b>c48fb37407365d4f2cd8</b></b></b></para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

    }

}
