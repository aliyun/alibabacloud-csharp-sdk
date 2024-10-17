// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteMediaInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs or URLs of media assets that cannot be deleted. Generally, media assets cannot be deleted if you do not have the required permissions.</para>
        /// </summary>
        [NameInMap("ForbiddenList")]
        [Validation(Required=false)]
        public List<string> ForbiddenList { get; set; }

        /// <summary>
        /// <para>The IDs or URLs of ignored media assets. An error occurred while obtaining such media assets.</para>
        /// </summary>
        [NameInMap("IgnoredList")]
        [Validation(Required=false)]
        public List<string> IgnoredList { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0622C702-41BE-467E-AF2E-883D4517962E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
