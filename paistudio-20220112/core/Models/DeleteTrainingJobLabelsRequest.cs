// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class DeleteTrainingJobLabelsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RootModelID</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public string Keys { get; set; }

    }

}
