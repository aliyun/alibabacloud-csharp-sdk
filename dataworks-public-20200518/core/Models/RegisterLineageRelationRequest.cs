// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RegisterLineageRelationRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LineageRelationRegisterVO")]
        [Validation(Required=false)]
        public LineageRelationRegisterVO LineageRelationRegisterVO { get; set; }

    }

}
