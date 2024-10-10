// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryTagsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e2ba19de97604f55b165576****</para>
        /// </summary>
        [NameInMap("ClientKey")]
        [Validation(Required=false)]
        public string ClientKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEVICE</para>
        /// </summary>
        [NameInMap("KeyType")]
        [Validation(Required=false)]
        public string KeyType { get; set; }

    }

}
