// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateAnnotationDataSetRequest : TeaModel {
        /// <summary>
        /// <para>The data structure of the request.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public MLDataSetParam Body { get; set; }

        /// <summary>
        /// <para>The unique identifier of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb8cc4eb51a85e823471cdb368fae9be</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

    }

}
