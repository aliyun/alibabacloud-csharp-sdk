// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateProjectModifyRecordsShrinkRequest : TeaModel {
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public string DatabasesShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np_fe****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("TransferMapping")]
        [Validation(Required=false)]
        public string TransferMappingShrink { get; set; }

    }

}
