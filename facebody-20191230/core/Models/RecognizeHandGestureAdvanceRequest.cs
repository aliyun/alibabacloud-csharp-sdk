// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizeHandGestureAdvanceRequest : TeaModel {
        [NameInMap("ImageURLObject")]
        [Validation(Required=true)]
        public Stream ImageURLObject { get; set; }

        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("GestureType")]
        [Validation(Required=false)]
        public string GestureType { get; set; }

    }

}
