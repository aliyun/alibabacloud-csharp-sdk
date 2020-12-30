// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageaudit20191230.Models
{
    public class ScanImageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScanImageResponseBodyData Data { get; set; }
        public class ScanImageResponseBodyData : TeaModel {
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<ScanImageResponseBodyDataResults> Results { get; set; }
            public class ScanImageResponseBodyDataResults : TeaModel {
                public string ImageURL { get; set; }
                public string DataId { get; set; }
                public List<ScanImageResponseBodyDataResultsSubResults> SubResults { get; set; }
                public class ScanImageResponseBodyDataResultsSubResults : TeaModel {
                    public List<ScanImageResponseBodyDataResultsSubResultsSfaceDataList> SfaceDataList { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsSfaceDataList : TeaModel {
                        public float? Width { get; set; }
                        public List<ScanImageResponseBodyDataResultsSubResultsSfaceDataListFaces> Faces { get; set; }
                        public class ScanImageResponseBodyDataResultsSubResultsSfaceDataListFaces : TeaModel {
                            public string Name { get; set; }
                            public string Id { get; set; }
                            public float? Rate { get; set; }
                        }
                        public float? Height { get; set; }
                        public float? Y { get; set; }
                        public float? X { get; set; }
                    }
                    public List<ScanImageResponseBodyDataResultsSubResultsHintWordsInfoList> HintWordsInfoList { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsHintWordsInfoList : TeaModel {
                        public string Context { get; set; }
                    }
                    public string Suggestion { get; set; }
                    public List<ScanImageResponseBodyDataResultsSubResultsProgramCodeDataList> ProgramCodeDataList { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsProgramCodeDataList : TeaModel {
                        public float? Width { get; set; }
                        public float? Height { get; set; }
                        public float? Y { get; set; }
                        public float? X { get; set; }
                    }
                    public List<string> OCRDataList { get; set; }
                    public List<ScanImageResponseBodyDataResultsSubResultsFrames> Frames { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsFrames : TeaModel {
                        public string URL { get; set; }
                        public float? Rate { get; set; }
                    }
                    public List<ScanImageResponseBodyDataResultsSubResultsLogoDataList> LogoDataList { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsLogoDataList : TeaModel {
                        public string Type { get; set; }
                        public float? Width { get; set; }
                        public float? Height { get; set; }
                        public float? Y { get; set; }
                        public string Name { get; set; }
                        public float? X { get; set; }
                    }
                    public string Label { get; set; }
                    public string Scene { get; set; }
                    public float? Rate { get; set; }
                }
                public string TaskId { get; set; }
            }
        };

    }

}
