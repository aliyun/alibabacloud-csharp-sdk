// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityScanRunRequest : TeaModel {
        [NameInMap("DataQualityScanId")]
        [Validation(Required=false)]
        public long? DataQualityScanId { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateDataQualityScanRunRequestParameters> Parameters { get; set; }
        public class CreateDataQualityScanRunRequestParameters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>regiondt</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai$[yyyy-mm-dd-1]</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public CreateDataQualityScanRunRequestRuntimeResource RuntimeResource { get; set; }
        public class CreateDataQualityScanRunRequestRuntimeResource : TeaModel {
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public float? Cu { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

        }

    }

}
