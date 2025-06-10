// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class ScreenChestCTResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScreenChestCTResponseBodyData Data { get; set; }
        public class ScreenChestCTResponseBodyData : TeaModel {
            [NameInMap("AnalyzeChestVessel")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataAnalyzeChestVessel AnalyzeChestVessel { get; set; }
            public class ScreenChestCTResponseBodyDataAnalyzeChestVessel : TeaModel {
                [NameInMap("AortaInfo")]
                [Validation(Required=false)]
                public ScreenChestCTResponseBodyDataAnalyzeChestVesselAortaInfo AortaInfo { get; set; }
                public class ScreenChestCTResponseBodyDataAnalyzeChestVesselAortaInfo : TeaModel {
                    /// <summary>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Area")]
                    [Validation(Required=false)]
                    public List<float?> Area { get; set; }

                    [NameInMap("Coordinates")]
                    [Validation(Required=false)]
                    public List<List<float?>> Coordinates { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("LabelValue")]
                    [Validation(Required=false)]
                    public long? LabelValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2722</para>
                    /// </summary>
                    [NameInMap("MaxArea")]
                    [Validation(Required=false)]
                    public float? MaxArea { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>416</para>
                    /// </summary>
                    [NameInMap("MaxAreaIndex")]
                    [Validation(Required=false)]
                    public long? MaxAreaIndex { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>63</para>
                    /// </summary>
                    [NameInMap("MaxDiameter")]
                    [Validation(Required=false)]
                    public float? MaxDiameter { get; set; }

                }

                [NameInMap("PulmonaryInfo")]
                [Validation(Required=false)]
                public ScreenChestCTResponseBodyDataAnalyzeChestVesselPulmonaryInfo PulmonaryInfo { get; set; }
                public class ScreenChestCTResponseBodyDataAnalyzeChestVesselPulmonaryInfo : TeaModel {
                    /// <summary>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Area")]
                    [Validation(Required=false)]
                    public List<float?> Area { get; set; }

                    [NameInMap("Coordinates")]
                    [Validation(Required=false)]
                    public List<List<float?>> Coordinates { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("LabelValue")]
                    [Validation(Required=false)]
                    public long? LabelValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>928</para>
                    /// </summary>
                    [NameInMap("MaxArea")]
                    [Validation(Required=false)]
                    public float? MaxArea { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxAreaIndex")]
                    [Validation(Required=false)]
                    public long? MaxAreaIndex { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>42</para>
                    /// </summary>
                    [NameInMap("MaxDiameter")]
                    [Validation(Required=false)]
                    public float? MaxDiameter { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2439</para>
                    /// </summary>
                    [NameInMap("NearestAortaArea")]
                    [Validation(Required=false)]
                    public float? NearestAortaArea { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/ct_artery_aa_ph/local_test/2021-07-08/6C4713DF-F548-47DF-A456-5DA1C8334444_result_compressed.tgz?Expires=1625732732&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&Signature=5UKVmLfM7GWllIcPr9a6dKz%2B5h">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/ct_artery_aa_ph/local_test/2021-07-08/6C4713DF-F548-47DF-A456-5DA1C8334444_result_compressed.tgz?Expires=1625732732&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&amp;Signature=5UKVmLfM7GWllIcPr9a6dKz%2B5h</a>****</para>
                /// </summary>
                [NameInMap("ResultURL")]
                [Validation(Required=false)]
                public string ResultURL { get; set; }

            }

            [NameInMap("CACS")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataCACS CACS { get; set; }
            public class ScreenChestCTResponseBodyDataCACS : TeaModel {
                [NameInMap("Detections")]
                [Validation(Required=false)]
                public List<ScreenChestCTResponseBodyDataCACSDetections> Detections { get; set; }
                public class ScreenChestCTResponseBodyDataCACSDetections : TeaModel {
                    [NameInMap("CalciumCenter")]
                    [Validation(Required=false)]
                    public List<long?> CalciumCenter { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CalciumId")]
                    [Validation(Required=false)]
                    public long? CalciumId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>19.22474</para>
                    /// </summary>
                    [NameInMap("CalciumScore")]
                    [Validation(Required=false)]
                    public float? CalciumScore { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>28.837109</para>
                    /// </summary>
                    [NameInMap("CalciumVolume")]
                    [Validation(Required=false)]
                    public float? CalciumVolume { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/calc-cacs/2020-09-29/2020-09-29-11%3A07%3A41-D74FE0DF-8F80-41EB-B08B-2E67053587EC.tar.gz?Expires=1601350661&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=iB16ms28Y5mzB11ghYUd7upCi4">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/calc-cacs/2020-09-29/2020-09-29-11%3A07%3A41-D74FE0DF-8F80-41EB-B08B-2E67053587EC.tar.gz?Expires=1601350661&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=iB16ms28Y5mzB11ghYUd7upCi4</a>****</para>
                /// </summary>
                [NameInMap("ResultUrl")]
                [Validation(Required=false)]
                public string ResultUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4.83</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.2.392.489642.9116.2.6.1.44063.1986736248.1658817546.650139</para>
                /// </summary>
                [NameInMap("SeriesInstanceUID")]
                [Validation(Required=false)]
                public string SeriesInstanceUID { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111.96</para>
                /// </summary>
                [NameInMap("VolumeScore")]
                [Validation(Required=false)]
                public string VolumeScore { get; set; }

            }

            [NameInMap("CalcBMD")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataCalcBMD CalcBMD { get; set; }
            public class ScreenChestCTResponseBodyDataCalcBMD : TeaModel {
                [NameInMap("Detections")]
                [Validation(Required=false)]
                public List<ScreenChestCTResponseBodyDataCalcBMDDetections> Detections { get; set; }
                public class ScreenChestCTResponseBodyDataCalcBMDDetections : TeaModel {
                    [NameInMap("VertBMD")]
                    [Validation(Required=false)]
                    public float? VertBMD { get; set; }

                    [NameInMap("VertCategory")]
                    [Validation(Required=false)]
                    public float? VertCategory { get; set; }

                    [NameInMap("VertId")]
                    [Validation(Required=false)]
                    public string VertId { get; set; }

                    [NameInMap("VertTScore")]
                    [Validation(Required=false)]
                    public float? VertTScore { get; set; }

                    [NameInMap("VertZScore")]
                    [Validation(Required=false)]
                    public float? VertZScore { get; set; }

                }

                [NameInMap("Origin")]
                [Validation(Required=false)]
                public List<float?> Origin { get; set; }

                [NameInMap("ResultURL")]
                [Validation(Required=false)]
                public string ResultURL { get; set; }

                [NameInMap("SeriesInstanceUid")]
                [Validation(Required=false)]
                public string SeriesInstanceUid { get; set; }

                [NameInMap("Spacing")]
                [Validation(Required=false)]
                public List<float?> Spacing { get; set; }

            }

            [NameInMap("Covid")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataCovid Covid { get; set; }
            public class ScreenChestCTResponseBodyDataCovid : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.9387283236994219</para>
                /// </summary>
                [NameInMap("LesionRatio")]
                [Validation(Required=false)]
                public string LesionRatio { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://algo-app-aic-med-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/covid19-dcm/unspecified/2020032702/1b1e1018-6fcf-11ea-8fa1-d20b34387541.nii.gz?Expires=1585276394&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=%2F1LNGWJUqvY0VRYGgg8Ldtb3BF">http://algo-app-aic-med-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/covid19-dcm/unspecified/2020032702/1b1e1018-6fcf-11ea-8fa1-d20b34387541.nii.gz?Expires=1585276394&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=%2F1LNGWJUqvY0VRYGgg8Ldtb3BF</a>****</para>
                /// </summary>
                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4.062644e-06</para>
                /// </summary>
                [NameInMap("NewProbability")]
                [Validation(Required=false)]
                public string NewProbability { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.7230905</para>
                /// </summary>
                [NameInMap("NormalProbability")]
                [Validation(Required=false)]
                public string NormalProbability { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.27690542</para>
                /// </summary>
                [NameInMap("OtherProbability")]
                [Validation(Required=false)]
                public string OtherProbability { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.2.392.200036.9116.2.6.1.44063.1805049129.1658817546.650139</para>
                /// </summary>
                [NameInMap("SeriesInstanceUID")]
                [Validation(Required=false)]
                public string SeriesInstanceUID { get; set; }

            }

            [NameInMap("DetectAD")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataDetectAD DetectAD { get; set; }
            public class ScreenChestCTResponseBodyDataDetectAD : TeaModel {
                [NameInMap("DistanceMap")]
                [Validation(Required=false)]
                public string DistanceMap { get; set; }

                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                [NameInMap("Possibility")]
                [Validation(Required=false)]
                public string Possibility { get; set; }

                [NameInMap("SeriesInstanceUid")]
                [Validation(Required=false)]
                public string SeriesInstanceUid { get; set; }

                [NameInMap("SliceVal")]
                [Validation(Required=false)]
                public int? SliceVal { get; set; }

            }

            [NameInMap("DetectLiverSteatosis")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataDetectLiverSteatosis DetectLiverSteatosis { get; set; }
            public class ScreenChestCTResponseBodyDataDetectLiverSteatosis : TeaModel {
                [NameInMap("Detections")]
                [Validation(Required=false)]
                public List<ScreenChestCTResponseBodyDataDetectLiverSteatosisDetections> Detections { get; set; }
                public class ScreenChestCTResponseBodyDataDetectLiverSteatosisDetections : TeaModel {
                    [NameInMap("FatFract")]
                    [Validation(Required=false)]
                    public double? FatFract { get; set; }

                    [NameInMap("LiverHU")]
                    [Validation(Required=false)]
                    public float? LiverHU { get; set; }

                    [NameInMap("LiverROI1")]
                    [Validation(Required=false)]
                    public float? LiverROI1 { get; set; }

                    [NameInMap("LiverROI2")]
                    [Validation(Required=false)]
                    public float? LiverROI2 { get; set; }

                    [NameInMap("LiverROI3")]
                    [Validation(Required=false)]
                    public float? LiverROI3 { get; set; }

                    [NameInMap("LiverSlice")]
                    [Validation(Required=false)]
                    public float? LiverSlice { get; set; }

                    [NameInMap("LiverSpleenDifference")]
                    [Validation(Required=false)]
                    public float? LiverSpleenDifference { get; set; }

                    [NameInMap("LiverSpleenRatio")]
                    [Validation(Required=false)]
                    public float? LiverSpleenRatio { get; set; }

                    [NameInMap("LiverVolume")]
                    [Validation(Required=false)]
                    public float? LiverVolume { get; set; }

                    [NameInMap("MaossScore")]
                    [Validation(Required=false)]
                    public double? MaossScore { get; set; }

                    [NameInMap("Prediction")]
                    [Validation(Required=false)]
                    public string Prediction { get; set; }

                    [NameInMap("Probability")]
                    [Validation(Required=false)]
                    public float? Probability { get; set; }

                    [NameInMap("ROI1Center")]
                    [Validation(Required=false)]
                    public List<long?> ROI1Center { get; set; }

                    [NameInMap("ROI2Center")]
                    [Validation(Required=false)]
                    public List<long?> ROI2Center { get; set; }

                    [NameInMap("ROI3Center")]
                    [Validation(Required=false)]
                    public List<long?> ROI3Center { get; set; }

                    [NameInMap("Radius")]
                    [Validation(Required=false)]
                    public long? Radius { get; set; }

                    [NameInMap("SpleenCenter")]
                    [Validation(Required=false)]
                    public List<long?> SpleenCenter { get; set; }

                    [NameInMap("SpleenHU")]
                    [Validation(Required=false)]
                    public float? SpleenHU { get; set; }

                    [NameInMap("SpleenROI")]
                    [Validation(Required=false)]
                    public float? SpleenROI { get; set; }

                    [NameInMap("SpleenSlice")]
                    [Validation(Required=false)]
                    public float? SpleenSlice { get; set; }

                    [NameInMap("SpleenVolume")]
                    [Validation(Required=false)]
                    public float? SpleenVolume { get; set; }

                }

                [NameInMap("Origin")]
                [Validation(Required=false)]
                public List<float?> Origin { get; set; }

                [NameInMap("ResultUrl")]
                [Validation(Required=false)]
                public string ResultUrl { get; set; }

                [NameInMap("SeriesInstanceUid")]
                [Validation(Required=false)]
                public string SeriesInstanceUid { get; set; }

                [NameInMap("Spacing")]
                [Validation(Required=false)]
                public List<float?> Spacing { get; set; }

            }

            [NameInMap("DetectLymph")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataDetectLymph DetectLymph { get; set; }
            public class ScreenChestCTResponseBodyDataDetectLymph : TeaModel {
                [NameInMap("Lesions")]
                [Validation(Required=false)]
                public List<ScreenChestCTResponseBodyDataDetectLymphLesions> Lesions { get; set; }
                public class ScreenChestCTResponseBodyDataDetectLymphLesions : TeaModel {
                    [NameInMap("Boxes")]
                    [Validation(Required=false)]
                    public List<float?> Boxes { get; set; }

                    [NameInMap("Diametermm")]
                    [Validation(Required=false)]
                    public List<float?> Diametermm { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("KeySlice")]
                    [Validation(Required=false)]
                    public long? KeySlice { get; set; }

                    [NameInMap("Recist")]
                    [Validation(Required=false)]
                    public List<List<float?>> Recist { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.6298</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.2.568.200036.9116.2.6.1.44063.1805049129.1357480934.650139</para>
                /// </summary>
                [NameInMap("SeriesInstanceUID")]
                [Validation(Required=false)]
                public string SeriesInstanceUID { get; set; }

            }

            [NameInMap("DetectPdac")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataDetectPdac DetectPdac { get; set; }
            public class ScreenChestCTResponseBodyDataDetectPdac : TeaModel {
                [NameInMap("Lesion")]
                [Validation(Required=false)]
                public ScreenChestCTResponseBodyDataDetectPdacLesion Lesion { get; set; }
                public class ScreenChestCTResponseBodyDataDetectPdacLesion : TeaModel {
                    [NameInMap("LesionList")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataDetectPdacLesionLesionList> LesionList { get; set; }
                    public class ScreenChestCTResponseBodyDataDetectPdacLesionLesionList : TeaModel {
                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public List<float?> Diameter { get; set; }

                        [NameInMap("KeySlice")]
                        [Validation(Required=false)]
                        public int? KeySlice { get; set; }

                        [NameInMap("ROIEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> ROIEndpoints { get; set; }

                        [NameInMap("RecistEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> RecistEndpoints { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen-pdac/2022-05-25_14%3A33%3A30/4CA2BF25-BCDB-9C6C-B14C-EB41E8266588.nii.gz?Expires=1653462210&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&Signature=8t%2FknUrQyyyCU2p7QhMC%2BXBCR">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen-pdac/2022-05-25_14%3A33%3A30/4CA2BF25-BCDB-9C6C-B14C-EB41E8266588.nii.gz?Expires=1653462210&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&amp;Signature=8t%2FknUrQyyyCU2p7QhMC%2BXBCR</a>****</para>
                    /// </summary>
                    [NameInMap("Mask")]
                    [Validation(Required=false)]
                    public string Mask { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("NonPdacVol")]
                    [Validation(Required=false)]
                    public string NonPdacVol { get; set; }

                    [NameInMap("OrganList")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataDetectPdacLesionOrganList> OrganList { get; set; }
                    public class ScreenChestCTResponseBodyDataDetectPdacLesionOrganList : TeaModel {
                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public List<float?> Diameter { get; set; }

                        [NameInMap("KeySlice")]
                        [Validation(Required=false)]
                        public int? KeySlice { get; set; }

                        [NameInMap("ROIEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> ROIEndpoints { get; set; }

                        [NameInMap("RecistEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> RecistEndpoints { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PancVol")]
                    [Validation(Required=false)]
                    public string PancVol { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PdacVol")]
                    [Validation(Required=false)]
                    public string PdacVol { get; set; }

                    [NameInMap("Possibilities")]
                    [Validation(Required=false)]
                    public List<string> Possibilities { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.2.239.200036.9116.2.6.1.44063.1805049129.1357480934.650139</para>
                /// </summary>
                [NameInMap("SeriesInstanceUID")]
                [Validation(Required=false)]
                public string SeriesInstanceUID { get; set; }

            }

            [NameInMap("DetectRibFracture")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataDetectRibFracture DetectRibFracture { get; set; }
            public class ScreenChestCTResponseBodyDataDetectRibFracture : TeaModel {
                [NameInMap("Detections")]
                [Validation(Required=false)]
                public List<ScreenChestCTResponseBodyDataDetectRibFractureDetections> Detections { get; set; }
                public class ScreenChestCTResponseBodyDataDetectRibFractureDetections : TeaModel {
                    [NameInMap("CoordinateImage")]
                    [Validation(Required=false)]
                    public List<long?> CoordinateImage { get; set; }

                    [NameInMap("Coordinates")]
                    [Validation(Required=false)]
                    public List<long?> Coordinates { get; set; }

                    [NameInMap("FracSOPInstanceUID")]
                    [Validation(Required=false)]
                    public string FracSOPInstanceUID { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("FractureCategory")]
                    [Validation(Required=false)]
                    public long? FractureCategory { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.7916666666666667</para>
                    /// </summary>
                    [NameInMap("FractureConfidence")]
                    [Validation(Required=false)]
                    public float? FractureConfidence { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("FractureId")]
                    [Validation(Required=false)]
                    public long? FractureId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>L4</para>
                    /// </summary>
                    [NameInMap("FractureLocation")]
                    [Validation(Required=false)]
                    public string FractureLocation { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("FractureSegment")]
                    [Validation(Required=false)]
                    public long? FractureSegment { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen-chest-ct/detect-rib-fracture/2022-07-27/2022-07-27-15_15_39-8BBD1C28-383A-548F-AD7D-CB5E0ABA207D_be6ffcb2d2e9494cba8112e07f93f466_ribFracture-mask.nii.gz?Expires=1659165340&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&Signature=2lzFDLfGbhVXsHm%2BKhgpglWmA">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen-chest-ct/detect-rib-fracture/2022-07-27/2022-07-27-15_15_39-8BBD1C28-383A-548F-AD7D-CB5E0ABA207D_be6ffcb2d2e9494cba8112e07f93f466_ribFracture-mask.nii.gz?Expires=1659165340&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&amp;Signature=2lzFDLfGbhVXsHm%2BKhgpglWmA</a>****</para>
                /// </summary>
                [NameInMap("FractureMaskURL")]
                [Validation(Required=false)]
                public string FractureMaskURL { get; set; }

                [NameInMap("Origin")]
                [Validation(Required=false)]
                public List<float?> Origin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/detect-rib-fracture/local_test/2020-12-22/result-D5CD101C-F8E5-43CA-9E99-44C783B8F8BE.tar.gz?Expires=1608631727&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=d6c32E1IB4b7Ayo1lpjs%2Bq3Ylv">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/detect-rib-fracture/local_test/2020-12-22/result-D5CD101C-F8E5-43CA-9E99-44C783B8F8BE.tar.gz?Expires=1608631727&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=d6c32E1IB4b7Ayo1lpjs%2Bq3Ylv</a>****</para>
                /// </summary>
                [NameInMap("ResultURL")]
                [Validation(Required=false)]
                public string ResultURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen-chest-ct/detect-rib-fracture/2022-07-27/2022-07-27-15_15_39-8BBD1C28-383A-548F-AD7D-CB5E0ABA207D_be6ffcb2d2e9494cba8112e07f93f466_ribFracture-ribmask.nii.gz?Expires=1659165340&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&Signature=5Z%2FCS3B%2B%2Ff6nlBk7alY39LvH3">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen-chest-ct/detect-rib-fracture/2022-07-27/2022-07-27-15_15_39-8BBD1C28-383A-548F-AD7D-CB5E0ABA207D_be6ffcb2d2e9494cba8112e07f93f466_ribFracture-ribmask.nii.gz?Expires=1659165340&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&amp;Signature=5Z%2FCS3B%2B%2Ff6nlBk7alY39LvH3</a>****</para>
                /// </summary>
                [NameInMap("RibSegmentMaskURL")]
                [Validation(Required=false)]
                public string RibSegmentMaskURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.2.392.489642.9116.2.6.1.78361.1298784213.1658817546.650139</para>
                /// </summary>
                [NameInMap("SeriesInstanceUID")]
                [Validation(Required=false)]
                public string SeriesInstanceUID { get; set; }

                [NameInMap("Spacing")]
                [Validation(Required=false)]
                public List<float?> Spacing { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Failed to execute [cacs,covid]</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("LungNodule")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataLungNodule LungNodule { get; set; }
            public class ScreenChestCTResponseBodyDataLungNodule : TeaModel {
                [NameInMap("Series")]
                [Validation(Required=false)]
                public List<ScreenChestCTResponseBodyDataLungNoduleSeries> Series { get; set; }
                public class ScreenChestCTResponseBodyDataLungNoduleSeries : TeaModel {
                    [NameInMap("Elements")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataLungNoduleSeriesElements> Elements { get; set; }
                    public class ScreenChestCTResponseBodyDataLungNoduleSeriesElements : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.7012705768508907</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public float? Confidence { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>9.730626493692398</para>
                        /// </summary>
                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public float? Diameter { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>308.9676976455463</para>
                        /// </summary>
                        [NameInMap("ImageX")]
                        [Validation(Required=false)]
                        public float? ImageX { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>198.3552282631497</para>
                        /// </summary>
                        [NameInMap("ImageY")]
                        [Validation(Required=false)]
                        public float? ImageY { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>198.3552282631497</para>
                        /// </summary>
                        [NameInMap("ImageZ")]
                        [Validation(Required=false)]
                        public float? ImageZ { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>up</para>
                        /// </summary>
                        [NameInMap("Lobe")]
                        [Validation(Required=false)]
                        public string Lobe { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>left</para>
                        /// </summary>
                        [NameInMap("Lung")]
                        [Validation(Required=false)]
                        public string Lung { get; set; }

                        [NameInMap("MajorAxis")]
                        [Validation(Required=false)]
                        public List<float?> MajorAxis { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>261.37589112119247</para>
                        /// </summary>
                        [NameInMap("MeanValue")]
                        [Validation(Required=false)]
                        public float? MeanValue { get; set; }

                        [NameInMap("MinorAxis")]
                        [Validation(Required=false)]
                        public List<float?> MinorAxis { get; set; }

                        [NameInMap("RecistSOPInstanceUID")]
                        [Validation(Required=false)]
                        public string RecistSOPInstanceUID { get; set; }

                        [NameInMap("Risk")]
                        [Validation(Required=false)]
                        public float? Risk { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1.3.6.1.4.1.14519.5.2.1.6279.6001.261151233960269013402330853013</para>
                        /// </summary>
                        [NameInMap("SOPInstanceUID")]
                        [Validation(Required=false)]
                        public string SOPInstanceUID { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10959.220491175074</para>
                        /// </summary>
                        [NameInMap("Volume")]
                        [Validation(Required=false)]
                        public float? Volume { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>51.24291240631416</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-32.23147700784307</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-46.81608170781766</para>
                        /// </summary>
                        [NameInMap("Z")]
                        [Validation(Required=false)]
                        public float? Z { get; set; }

                    }

                    [NameInMap("Origin")]
                    [Validation(Required=false)]
                    public List<float?> Origin { get; set; }

                    [NameInMap("Report")]
                    [Validation(Required=false)]
                    public string Report { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.3.6.1.4.1.14519.5.2.1.6279.6001.179049373636438705059720603192</para>
                    /// </summary>
                    [NameInMap("SeriesInstanceUid")]
                    [Validation(Required=false)]
                    public string SeriesInstanceUid { get; set; }

                    [NameInMap("Spacing")]
                    [Validation(Required=false)]
                    public List<float?> Spacing { get; set; }

                }

            }

            [NameInMap("MuscleFat")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataMuscleFat MuscleFat { get; set; }
            public class ScreenChestCTResponseBodyDataMuscleFat : TeaModel {
                [NameInMap("FAT_TYPE")]
                [Validation(Required=false)]
                public int? FAT_TYPE { get; set; }

                [NameInMap("MASK_PATH")]
                [Validation(Required=false)]
                public string MASK_PATH { get; set; }

                [NameInMap("MUSCLE_MASS")]
                [Validation(Required=false)]
                public int? MUSCLE_MASS { get; set; }

                [NameInMap("MUSCLE_QUALITY")]
                [Validation(Required=false)]
                public int? MUSCLE_QUALITY { get; set; }

                [NameInMap("NAMA_TAMA_INDEX_TSCORE")]
                [Validation(Required=false)]
                public float? NAMA_TAMA_INDEX_TSCORE { get; set; }

                [NameInMap("PERCENT_IMAT")]
                [Validation(Required=false)]
                public float? PERCENT_IMAT { get; set; }

                [NameInMap("PERCENT_LAMA")]
                [Validation(Required=false)]
                public float? PERCENT_LAMA { get; set; }

                [NameInMap("PERCENT_NAMA")]
                [Validation(Required=false)]
                public float? PERCENT_NAMA { get; set; }

                [NameInMap("RENDERING_PATH")]
                [Validation(Required=false)]
                public string RENDERING_PATH { get; set; }

                [NameInMap("SFA")]
                [Validation(Required=false)]
                public float? SFA { get; set; }

                [NameInMap("SFT")]
                [Validation(Required=false)]
                public float? SFT { get; set; }

                [NameInMap("SMA")]
                [Validation(Required=false)]
                public float? SMA { get; set; }

                [NameInMap("SMI")]
                [Validation(Required=false)]
                public float? SMI { get; set; }

                [NameInMap("STUDY_AGE")]
                [Validation(Required=false)]
                public int? STUDY_AGE { get; set; }

                [NameInMap("STUDY_GENDER")]
                [Validation(Required=false)]
                public string STUDY_GENDER { get; set; }

                [NameInMap("SeriesInstanceUid")]
                [Validation(Required=false)]
                public string SeriesInstanceUid { get; set; }

                [NameInMap("VERTEBRA_IN_USE")]
                [Validation(Required=false)]
                public float? VERTEBRA_IN_USE { get; set; }

                [NameInMap("VFA")]
                [Validation(Required=false)]
                public float? VFA { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://medclients-sh.oss-cn-shanghai.aliyuncs.com/demo/coronacases_org_001/1.2.112.92121.1.1689.19.2.2020040219072764787101585825****.dcm">https://medclients-sh.oss-cn-shanghai.aliyuncs.com/demo/coronacases_org_001/1.2.112.92121.1.1689.19.2.2020040219072764787101585825****.dcm</a></para>
            /// </summary>
            [NameInMap("NestedUrlList")]
            [Validation(Required=false)]
            public Dictionary<string, object> NestedUrlList { get; set; }

            [NameInMap("PredictCVD")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataPredictCVD PredictCVD { get; set; }
            public class ScreenChestCTResponseBodyDataPredictCVD : TeaModel {
                [NameInMap("Lesion")]
                [Validation(Required=false)]
                public ScreenChestCTResponseBodyDataPredictCVDLesion Lesion { get; set; }
                public class ScreenChestCTResponseBodyDataPredictCVDLesion : TeaModel {
                    [NameInMap("CVDProbability")]
                    [Validation(Required=false)]
                    public double? CVDProbability { get; set; }

                    [NameInMap("FeatureScore")]
                    [Validation(Required=false)]
                    public ScreenChestCTResponseBodyDataPredictCVDLesionFeatureScore FeatureScore { get; set; }
                    public class ScreenChestCTResponseBodyDataPredictCVDLesionFeatureScore : TeaModel {
                        [NameInMap("AortaCalciumScore")]
                        [Validation(Required=false)]
                        public List<double?> AortaCalciumScore { get; set; }

                        [NameInMap("AortaCalciumVolume")]
                        [Validation(Required=false)]
                        public List<double?> AortaCalciumVolume { get; set; }

                        [NameInMap("AortaMaxDiam")]
                        [Validation(Required=false)]
                        public List<double?> AortaMaxDiam { get; set; }

                        [NameInMap("AortaMaxDiamStd")]
                        [Validation(Required=false)]
                        public List<double?> AortaMaxDiamStd { get; set; }

                        [NameInMap("AorticHeightIndex")]
                        [Validation(Required=false)]
                        public List<double?> AorticHeightIndex { get; set; }

                        [NameInMap("AorticTortuosityIndex")]
                        [Validation(Required=false)]
                        public List<double?> AorticTortuosityIndex { get; set; }

                        [NameInMap("AscAoMaxDiam")]
                        [Validation(Required=false)]
                        public List<double?> AscAoMaxDiam { get; set; }

                        [NameInMap("AscendAortaLength")]
                        [Validation(Required=false)]
                        public List<double?> AscendAortaLength { get; set; }

                        [NameInMap("CardioThoracicRatio")]
                        [Validation(Required=false)]
                        public List<double?> CardioThoracicRatio { get; set; }

                        [NameInMap("ChestWidth")]
                        [Validation(Required=false)]
                        public List<double?> ChestWidth { get; set; }

                        [NameInMap("CoronaryCalciumScore")]
                        [Validation(Required=false)]
                        public List<double?> CoronaryCalciumScore { get; set; }

                        [NameInMap("CoronaryCalciumVol")]
                        [Validation(Required=false)]
                        public List<double?> CoronaryCalciumVol { get; set; }

                        [NameInMap("DeepFeature")]
                        [Validation(Required=false)]
                        public List<double?> DeepFeature { get; set; }

                        [NameInMap("EatHUMean")]
                        [Validation(Required=false)]
                        public List<double?> EatHUMean { get; set; }

                        [NameInMap("EatHUSTD")]
                        [Validation(Required=false)]
                        public List<double?> EatHUSTD { get; set; }

                        [NameInMap("EatVolume")]
                        [Validation(Required=false)]
                        public List<double?> EatVolume { get; set; }

                        [NameInMap("HeartLongDiam")]
                        [Validation(Required=false)]
                        public List<double?> HeartLongDiam { get; set; }

                        [NameInMap("HeartShortDiam")]
                        [Validation(Required=false)]
                        public List<double?> HeartShortDiam { get; set; }

                        [NameInMap("HeartWidth")]
                        [Validation(Required=false)]
                        public List<double?> HeartWidth { get; set; }

                        [NameInMap("LeftLungHighattRatio")]
                        [Validation(Required=false)]
                        public List<double?> LeftLungHighattRatio { get; set; }

                        [NameInMap("LeftLungLowattRatio")]
                        [Validation(Required=false)]
                        public List<double?> LeftLungLowattRatio { get; set; }

                        [NameInMap("MyoEpiRatio")]
                        [Validation(Required=false)]
                        public List<double?> MyoEpiRatio { get; set; }

                        [NameInMap("RightLungHighattRatio")]
                        [Validation(Required=false)]
                        public List<double?> RightLungHighattRatio { get; set; }

                        [NameInMap("RightLungLowattRatio")]
                        [Validation(Required=false)]
                        public List<double?> RightLungLowattRatio { get; set; }

                    }

                    [NameInMap("ImagesURL")]
                    [Validation(Required=false)]
                    public string ImagesURL { get; set; }

                    [NameInMap("ResultURL")]
                    [Validation(Required=false)]
                    public List<string> ResultURL { get; set; }

                }

                [NameInMap("SeriesInstanceUid")]
                [Validation(Required=false)]
                public string SeriesInstanceUid { get; set; }

            }

            [NameInMap("ScreenBC")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataScreenBC ScreenBC { get; set; }
            public class ScreenChestCTResponseBodyDataScreenBC : TeaModel {
                [NameInMap("Lesion")]
                [Validation(Required=false)]
                public ScreenChestCTResponseBodyDataScreenBCLesion Lesion { get; set; }
                public class ScreenChestCTResponseBodyDataScreenBCLesion : TeaModel {
                    [NameInMap("Left")]
                    [Validation(Required=false)]
                    public ScreenChestCTResponseBodyDataScreenBCLesionLeft Left { get; set; }
                    public class ScreenChestCTResponseBodyDataScreenBCLesionLeft : TeaModel {
                        [NameInMap("BCVolume")]
                        [Validation(Required=false)]
                        public string BCVolume { get; set; }

                        [NameInMap("BreastVolume")]
                        [Validation(Required=false)]
                        public string BreastVolume { get; set; }

                        [NameInMap("Probabilities")]
                        [Validation(Required=false)]
                        public List<string> Probabilities { get; set; }

                    }

                    [NameInMap("LesionList")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataScreenBCLesionLesionList> LesionList { get; set; }
                    public class ScreenChestCTResponseBodyDataScreenBCLesionLesionList : TeaModel {
                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public List<float?> Diameter { get; set; }

                        [NameInMap("KeySlice")]
                        [Validation(Required=false)]
                        public int? KeySlice { get; set; }

                        [NameInMap("ROIEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> ROIEndpoints { get; set; }

                        [NameInMap("RecistEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> RecistEndpoints { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Mask")]
                    [Validation(Required=false)]
                    public string Mask { get; set; }

                    [NameInMap("OrganList")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataScreenBCLesionOrganList> OrganList { get; set; }
                    public class ScreenChestCTResponseBodyDataScreenBCLesionOrganList : TeaModel {
                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public List<float?> Diameter { get; set; }

                        [NameInMap("KeySlice")]
                        [Validation(Required=false)]
                        public int? KeySlice { get; set; }

                        [NameInMap("ROIEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> ROIEndpoints { get; set; }

                        [NameInMap("RecistEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> RecistEndpoints { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Right")]
                    [Validation(Required=false)]
                    public ScreenChestCTResponseBodyDataScreenBCLesionRight Right { get; set; }
                    public class ScreenChestCTResponseBodyDataScreenBCLesionRight : TeaModel {
                        [NameInMap("BCVolume")]
                        [Validation(Required=false)]
                        public string BCVolume { get; set; }

                        [NameInMap("BreastVolume")]
                        [Validation(Required=false)]
                        public string BreastVolume { get; set; }

                        [NameInMap("Probabilities")]
                        [Validation(Required=false)]
                        public List<string> Probabilities { get; set; }

                    }

                }

                [NameInMap("SeriesInstanceUid")]
                [Validation(Required=false)]
                public string SeriesInstanceUid { get; set; }

            }

            [NameInMap("ScreenCRC")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataScreenCRC ScreenCRC { get; set; }
            public class ScreenChestCTResponseBodyDataScreenCRC : TeaModel {
                [NameInMap("Lesion")]
                [Validation(Required=false)]
                public ScreenChestCTResponseBodyDataScreenCRCLesion Lesion { get; set; }
                public class ScreenChestCTResponseBodyDataScreenCRCLesion : TeaModel {
                    [NameInMap("ColorectumVolume")]
                    [Validation(Required=false)]
                    public string ColorectumVolume { get; set; }

                    [NameInMap("LesionList")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataScreenCRCLesionLesionList> LesionList { get; set; }
                    public class ScreenChestCTResponseBodyDataScreenCRCLesionLesionList : TeaModel {
                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public List<float?> Diameter { get; set; }

                        [NameInMap("KeySlice")]
                        [Validation(Required=false)]
                        public int? KeySlice { get; set; }

                        [NameInMap("ROIEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> ROIEndpoints { get; set; }

                        [NameInMap("RecistEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> RecistEndpoints { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Mask")]
                    [Validation(Required=false)]
                    public string Mask { get; set; }

                    [NameInMap("OrganList")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataScreenCRCLesionOrganList> OrganList { get; set; }
                    public class ScreenChestCTResponseBodyDataScreenCRCLesionOrganList : TeaModel {
                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public List<float?> Diameter { get; set; }

                        [NameInMap("KeySlice")]
                        [Validation(Required=false)]
                        public int? KeySlice { get; set; }

                        [NameInMap("ROIEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> ROIEndpoints { get; set; }

                        [NameInMap("RecistEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> RecistEndpoints { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Probabilities")]
                    [Validation(Required=false)]
                    public List<string> Probabilities { get; set; }

                }

                [NameInMap("SeriesInstanceUid")]
                [Validation(Required=false)]
                public string SeriesInstanceUid { get; set; }

            }

            [NameInMap("ScreenEc")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataScreenEc ScreenEc { get; set; }
            public class ScreenChestCTResponseBodyDataScreenEc : TeaModel {
                [NameInMap("Lesion")]
                [Validation(Required=false)]
                public ScreenChestCTResponseBodyDataScreenEcLesion Lesion { get; set; }
                public class ScreenChestCTResponseBodyDataScreenEcLesion : TeaModel {
                    [NameInMap("BenignVolume")]
                    [Validation(Required=false)]
                    public string BenignVolume { get; set; }

                    [NameInMap("EcVolume")]
                    [Validation(Required=false)]
                    public string EcVolume { get; set; }

                    [NameInMap("EgjVolume")]
                    [Validation(Required=false)]
                    public string EgjVolume { get; set; }

                    [NameInMap("EsoVolume")]
                    [Validation(Required=false)]
                    public string EsoVolume { get; set; }

                    [NameInMap("LesionList")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataScreenEcLesionLesionList> LesionList { get; set; }
                    public class ScreenChestCTResponseBodyDataScreenEcLesionLesionList : TeaModel {
                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public List<float?> Diameter { get; set; }

                        [NameInMap("KeySlice")]
                        [Validation(Required=false)]
                        public int? KeySlice { get; set; }

                        [NameInMap("ROIEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> ROIEndpoints { get; set; }

                        [NameInMap("RecistEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> RecistEndpoints { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Mask")]
                    [Validation(Required=false)]
                    public string Mask { get; set; }

                    [NameInMap("OrganList")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataScreenEcLesionOrganList> OrganList { get; set; }
                    public class ScreenChestCTResponseBodyDataScreenEcLesionOrganList : TeaModel {
                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public List<float?> Diameter { get; set; }

                        [NameInMap("KeySlice")]
                        [Validation(Required=false)]
                        public int? KeySlice { get; set; }

                        [NameInMap("ROIEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> ROIEndpoints { get; set; }

                        [NameInMap("RecistEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> RecistEndpoints { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Possibilities")]
                    [Validation(Required=false)]
                    public List<string> Possibilities { get; set; }

                }

                [NameInMap("SeriesInstanceUid")]
                [Validation(Required=false)]
                public string SeriesInstanceUid { get; set; }

            }

            [NameInMap("ScreenGC")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataScreenGC ScreenGC { get; set; }
            public class ScreenChestCTResponseBodyDataScreenGC : TeaModel {
                [NameInMap("Lesion")]
                [Validation(Required=false)]
                public ScreenChestCTResponseBodyDataScreenGCLesion Lesion { get; set; }
                public class ScreenChestCTResponseBodyDataScreenGCLesion : TeaModel {
                    [NameInMap("GCVolume")]
                    [Validation(Required=false)]
                    public string GCVolume { get; set; }

                    [NameInMap("LesionList")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataScreenGCLesionLesionList> LesionList { get; set; }
                    public class ScreenChestCTResponseBodyDataScreenGCLesionLesionList : TeaModel {
                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public List<float?> Diameter { get; set; }

                        [NameInMap("KeySlice")]
                        [Validation(Required=false)]
                        public int? KeySlice { get; set; }

                        [NameInMap("ROIEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> ROIEndpoints { get; set; }

                        [NameInMap("RecistEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> RecistEndpoints { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Mask")]
                    [Validation(Required=false)]
                    public string Mask { get; set; }

                    [NameInMap("NonGCVolume")]
                    [Validation(Required=false)]
                    public string NonGCVolume { get; set; }

                    [NameInMap("OrganList")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataScreenGCLesionOrganList> OrganList { get; set; }
                    public class ScreenChestCTResponseBodyDataScreenGCLesionOrganList : TeaModel {
                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public List<float?> Diameter { get; set; }

                        [NameInMap("KeySlice")]
                        [Validation(Required=false)]
                        public int? KeySlice { get; set; }

                        [NameInMap("ROIEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> ROIEndpoints { get; set; }

                        [NameInMap("RecistEndpoints")]
                        [Validation(Required=false)]
                        public List<List<int?>> RecistEndpoints { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Probabilities")]
                    [Validation(Required=false)]
                    public List<string> Probabilities { get; set; }

                    [NameInMap("StomachVolume")]
                    [Validation(Required=false)]
                    public string StomachVolume { get; set; }

                }

                [NameInMap("SeriesInstanceUid")]
                [Validation(Required=false)]
                public string SeriesInstanceUid { get; set; }

            }

            [NameInMap("ScreenLC")]
            [Validation(Required=false)]
            public ScreenChestCTResponseBodyDataScreenLC ScreenLC { get; set; }
            public class ScreenChestCTResponseBodyDataScreenLC : TeaModel {
                [NameInMap("Lesion")]
                [Validation(Required=false)]
                public ScreenChestCTResponseBodyDataScreenLCLesion Lesion { get; set; }
                public class ScreenChestCTResponseBodyDataScreenLCLesion : TeaModel {
                    [NameInMap("LesionList")]
                    [Validation(Required=false)]
                    public List<ScreenChestCTResponseBodyDataScreenLCLesionLesionList> LesionList { get; set; }
                    public class ScreenChestCTResponseBodyDataScreenLCLesionLesionList : TeaModel {
                        [NameInMap("Diameter")]
                        [Validation(Required=false)]
                        public List<float?> Diameter { get; set; }

                        [NameInMap("KeySlice")]
                        [Validation(Required=false)]
                        public long? KeySlice { get; set; }

                        [NameInMap("Malignancy")]
                        [Validation(Required=false)]
                        public float? Malignancy { get; set; }

                        [NameInMap("RecistEndpoints")]
                        [Validation(Required=false)]
                        public List<float?> RecistEndpoints { get; set; }

                        [NameInMap("ScoreAllClasses")]
                        [Validation(Required=false)]
                        public ScreenChestCTResponseBodyDataScreenLCLesionLesionListScoreAllClasses ScoreAllClasses { get; set; }
                        public class ScreenChestCTResponseBodyDataScreenLCLesionLesionListScoreAllClasses : TeaModel {
                            [NameInMap("BenignProb")]
                            [Validation(Required=false)]
                            public float? BenignProb { get; set; }

                            [NameInMap("CalcProb")]
                            [Validation(Required=false)]
                            public float? CalcProb { get; set; }

                            [NameInMap("CystProb")]
                            [Validation(Required=false)]
                            public float? CystProb { get; set; }

                            [NameInMap("MalignantProb")]
                            [Validation(Required=false)]
                            public float? MalignantProb { get; set; }

                        }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Volume")]
                        [Validation(Required=false)]
                        public float? Volume { get; set; }

                    }

                    [NameInMap("LiverVolume")]
                    [Validation(Required=false)]
                    public string LiverVolume { get; set; }

                    [NameInMap("Mask")]
                    [Validation(Required=false)]
                    public string Mask { get; set; }

                    [NameInMap("PatientLevelProb")]
                    [Validation(Required=false)]
                    public float? PatientLevelProb { get; set; }

                    [NameInMap("PatientLevelResult")]
                    [Validation(Required=false)]
                    public ScreenChestCTResponseBodyDataScreenLCLesionPatientLevelResult PatientLevelResult { get; set; }
                    public class ScreenChestCTResponseBodyDataScreenLCLesionPatientLevelResult : TeaModel {
                        [NameInMap("BenignNonCystProb")]
                        [Validation(Required=false)]
                        public string BenignNonCystProb { get; set; }

                        [NameInMap("BenignProb")]
                        [Validation(Required=false)]
                        public string BenignProb { get; set; }

                        [NameInMap("CalcProb")]
                        [Validation(Required=false)]
                        public string CalcProb { get; set; }

                        [NameInMap("CystProb")]
                        [Validation(Required=false)]
                        public string CystProb { get; set; }

                        [NameInMap("HCCProb")]
                        [Validation(Required=false)]
                        public string HCCProb { get; set; }

                        [NameInMap("MalignantNonHCCProb")]
                        [Validation(Required=false)]
                        public string MalignantNonHCCProb { get; set; }

                        [NameInMap("MalignantProb")]
                        [Validation(Required=false)]
                        public string MalignantProb { get; set; }

                    }

                }

                [NameInMap("SeriesInstanceUid")]
                [Validation(Required=false)]
                public string SeriesInstanceUid { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://medclients-sh.oss-cn-shanghai.aliyuncs.com/demo/coronacases_org_001/1.2.112.92121.1.1689.19.2.2020040219072764787101585825****.dcm">https://medclients-sh.oss-cn-shanghai.aliyuncs.com/demo/coronacases_org_001/1.2.112.92121.1.1689.19.2.2020040219072764787101585825****.dcm</a></para>
            /// </summary>
            [NameInMap("URLList")]
            [Validation(Required=false)]
            public Dictionary<string, object> URLList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>imageUrl download failed</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>528B54D4-3AAB-47CF-B6CE-0C2A2FB4C7C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
