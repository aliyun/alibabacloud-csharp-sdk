// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PutAnnotationDataRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2156d560fc7c01420542df92cd6365ds</para>
        /// </summary>
        [NameInMap("annotationdataId")]
        [Validation(Required=false)]
        public string AnnotationdataId { get; set; }

        /// <summary>
        /// <para>The data structure of the request.</para>
        /// </summary>
        [NameInMap("mlDataParam")]
        [Validation(Required=false)]
        public MLDataParam MlDataParam { get; set; }

        /// <summary>
        /// <para>The raw log data.</para>
        /// </summary>
        [NameInMap("rawLog")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> RawLog { get; set; }

    }

}
