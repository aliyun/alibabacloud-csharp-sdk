// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class DataSubImagesKvInfoKvDetailsValue : TeaModel {
        [NameInMap("KeyName")]
        [Validation(Required=false)]
        public string KeyName { get; set; }

        [NameInMap("KeyConfidence")]
        [Validation(Required=false)]
        public int? KeyConfidence { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("ValueConfidence")]
        [Validation(Required=false)]
        public int? ValueConfidence { get; set; }

        [NameInMap("ValuePoints")]
        [Validation(Required=false)]
        public List<DataSubImagesKvInfoKvDetailsValueValuePoints> ValuePoints { get; set; }
        public class DataSubImagesKvInfoKvDetailsValueValuePoints : TeaModel {
            [NameInMap("X")]
            [Validation(Required=false)]
            public int? X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public int? Y { get; set; }

        }

        [NameInMap("ValueRect")]
        [Validation(Required=false)]
        public DataSubImagesKvInfoKvDetailsValueValueRect ValueRect { get; set; }
        public class DataSubImagesKvInfoKvDetailsValueValueRect : TeaModel {
            [NameInMap("CenterX")]
            [Validation(Required=false)]
            public int? CenterX { get; set; }

            [NameInMap("CenterY")]
            [Validation(Required=false)]
            public int? CenterY { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

        }

        [NameInMap("ValueAngle")]
        [Validation(Required=false)]
        public int? ValueAngle { get; set; }

    }

}
