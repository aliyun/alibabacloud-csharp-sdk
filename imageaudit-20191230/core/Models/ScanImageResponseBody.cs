// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageaudit20191230.Models
{
    public class ScanImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScanImageResponseBodyData Data { get; set; }
        public class ScanImageResponseBodyData : TeaModel {
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<ScanImageResponseBodyDataResults> Results { get; set; }
            public class ScanImageResponseBodyDataResults : TeaModel {
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("SubResults")]
                [Validation(Required=false)]
                public List<ScanImageResponseBodyDataResultsSubResults> SubResults { get; set; }
                public class ScanImageResponseBodyDataResultsSubResults : TeaModel {
                    [NameInMap("Frames")]
                    [Validation(Required=false)]
                    public List<ScanImageResponseBodyDataResultsSubResultsFrames> Frames { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsFrames : TeaModel {
                        [NameInMap("Rate")]
                        [Validation(Required=false)]
                        public float? Rate { get; set; }

                        [NameInMap("URL")]
                        [Validation(Required=false)]
                        public string URL { get; set; }

                    }

                    [NameInMap("HintWordsInfoList")]
                    [Validation(Required=false)]
                    public List<ScanImageResponseBodyDataResultsSubResultsHintWordsInfoList> HintWordsInfoList { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsHintWordsInfoList : TeaModel {
                        [NameInMap("Context")]
                        [Validation(Required=false)]
                        public string Context { get; set; }

                    }

                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("LogoDataList")]
                    [Validation(Required=false)]
                    public List<ScanImageResponseBodyDataResultsSubResultsLogoDataList> LogoDataList { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsLogoDataList : TeaModel {
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public float? Height { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    /// <summary>
                    /// 1
                    /// </summary>
                    [NameInMap("OCRDataList")]
                    [Validation(Required=false)]
                    public List<string> OCRDataList { get; set; }

                    [NameInMap("ProgramCodeDataList")]
                    [Validation(Required=false)]
                    public List<ScanImageResponseBodyDataResultsSubResultsProgramCodeDataList> ProgramCodeDataList { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsProgramCodeDataList : TeaModel {
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public float? Height { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    [NameInMap("SfaceDataList")]
                    [Validation(Required=false)]
                    public List<ScanImageResponseBodyDataResultsSubResultsSfaceDataList> SfaceDataList { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsSfaceDataList : TeaModel {
                        [NameInMap("Faces")]
                        [Validation(Required=false)]
                        public List<ScanImageResponseBodyDataResultsSubResultsSfaceDataListFaces> Faces { get; set; }
                        public class ScanImageResponseBodyDataResultsSubResultsSfaceDataListFaces : TeaModel {
                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("Rate")]
                            [Validation(Required=false)]
                            public float? Rate { get; set; }

                        }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public float? Height { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
