// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetLineageRelationshipResponseBody : TeaModel {
        [NameInMap("LineageRelationship")]
        [Validation(Required=false)]
        public LineageRelationship LineageRelationship { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>58D5334A-B013-430E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
