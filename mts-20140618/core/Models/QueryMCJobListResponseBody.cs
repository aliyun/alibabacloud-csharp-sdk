// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMCJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("JobList")]
        [Validation(Required=false)]
        public QueryMCJobListResponseBodyJobList JobList { get; set; }
        public class QueryMCJobListResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryMCJobListResponseBodyJobListJob> Job { get; set; }
            public class QueryMCJobListResponseBodyJobListJob : TeaModel {
                public string CreationTime { get; set; }
                public string ResultOutputFile { get; set; }
                public QueryMCJobListResponseBodyJobListJobResult Result { get; set; }
                public class QueryMCJobListResponseBodyJobListJobResult : TeaModel {
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    [NameInMap("PornResult")]
                    [Validation(Required=false)]
                    public QueryMCJobListResponseBodyJobListJobResultPornResult PornResult { get; set; }
                    public class QueryMCJobListResponseBodyJobListJobResultPornResult : TeaModel {
                        [NameInMap("PornTexts")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultPornResultPornTexts PornTexts { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultPornResultPornTexts : TeaModel {
                            [NameInMap("PornText")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultPornResultPornTextsPornText> PornText { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultPornResultPornTextsPornText : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                        [NameInMap("PornVideos")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultPornResultPornVideos PornVideos { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultPornResultPornVideos : TeaModel {
                            [NameInMap("PornVideo")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultPornResultPornVideosPornVideo> PornVideo { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultPornResultPornVideosPornVideo : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("PornAudios")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultPornResultPornAudios PornAudios { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultPornResultPornAudios : TeaModel {
                            [NameInMap("PornAudio")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultPornResultPornAudiosPornAudio> PornAudio { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultPornResultPornAudiosPornAudio : TeaModel {
                                [NameInMap("EndTime")]
                                [Validation(Required=false)]
                                public string EndTime { get; set; }

                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("PornImages")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultPornResultPornImages PornImages { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultPornResultPornImages : TeaModel {
                            [NameInMap("PornImage")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultPornResultPornImagesPornImage> PornImage { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultPornResultPornImagesPornImage : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Url")]
                                [Validation(Required=false)]
                                public string Url { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                        [NameInMap("PornOcrs")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultPornResultPornOcrs PornOcrs { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultPornResultPornOcrs : TeaModel {
                            [NameInMap("PornOcr")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultPornResultPornOcrsPornOcr> PornOcr { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultPornResultPornOcrsPornOcr : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                    };

                    [NameInMap("AdResult")]
                    [Validation(Required=false)]
                    public QueryMCJobListResponseBodyJobListJobResultAdResult AdResult { get; set; }
                    public class QueryMCJobListResponseBodyJobListJobResultAdResult : TeaModel {
                        [NameInMap("AdOcrs")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultAdResultAdOcrs AdOcrs { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultAdResultAdOcrs : TeaModel {
                            [NameInMap("AdOcr")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultAdResultAdOcrsAdOcr> AdOcr { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultAdResultAdOcrsAdOcr : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("AdTexts")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultAdResultAdTexts AdTexts { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultAdResultAdTexts : TeaModel {
                            [NameInMap("AdText")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultAdResultAdTextsAdText> AdText { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultAdResultAdTextsAdText : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                        [NameInMap("AdImages")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultAdResultAdImages AdImages { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultAdResultAdImages : TeaModel {
                            [NameInMap("AdImage")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultAdResultAdImagesAdImage> AdImage { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultAdResultAdImagesAdImage : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Url")]
                                [Validation(Required=false)]
                                public string Url { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                        [NameInMap("AdAudios")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultAdResultAdAudios AdAudios { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultAdResultAdAudios : TeaModel {
                            [NameInMap("AdAudio")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultAdResultAdAudiosAdAudio> AdAudio { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultAdResultAdAudiosAdAudio : TeaModel {
                                [NameInMap("EndTime")]
                                [Validation(Required=false)]
                                public string EndTime { get; set; }

                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("AdVideos")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultAdResultAdVideos AdVideos { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultAdResultAdVideos : TeaModel {
                            [NameInMap("AdVideo")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultAdResultAdVideosAdVideo> AdVideo { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultAdResultAdVideosAdVideo : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                    };

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public string Score { get; set; }

                    [NameInMap("LogoResult")]
                    [Validation(Required=false)]
                    public QueryMCJobListResponseBodyJobListJobResultLogoResult LogoResult { get; set; }
                    public class QueryMCJobListResponseBodyJobListJobResultLogoResult : TeaModel {
                        [NameInMap("LogoImages")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultLogoResultLogoImages LogoImages { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultLogoResultLogoImages : TeaModel {
                            [NameInMap("LogoImage")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultLogoResultLogoImagesLogoImage> LogoImage { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultLogoResultLogoImagesLogoImage : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Url")]
                                [Validation(Required=false)]
                                public string Url { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                        [NameInMap("LogoVideos")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultLogoResultLogoVideos LogoVideos { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultLogoResultLogoVideos : TeaModel {
                            [NameInMap("LogoVideo")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultLogoResultLogoVideosLogoVideo> LogoVideo { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultLogoResultLogoVideosLogoVideo : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                    };

                    [NameInMap("QrcodeResult")]
                    [Validation(Required=false)]
                    public QueryMCJobListResponseBodyJobListJobResultQrcodeResult QrcodeResult { get; set; }
                    public class QueryMCJobListResponseBodyJobListJobResultQrcodeResult : TeaModel {
                        [NameInMap("QrcodeImages")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultQrcodeResultQrcodeImages QrcodeImages { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultQrcodeResultQrcodeImages : TeaModel {
                            [NameInMap("QrcodeImage")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultQrcodeResultQrcodeImagesQrcodeImage> QrcodeImage { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultQrcodeResultQrcodeImagesQrcodeImage : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Url")]
                                [Validation(Required=false)]
                                public string Url { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                        [NameInMap("QrcodeVideos")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultQrcodeResultQrcodeVideos QrcodeVideos { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultQrcodeResultQrcodeVideos : TeaModel {
                            [NameInMap("QrcodeVideo")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultQrcodeResultQrcodeVideosQrcodeVideo> QrcodeVideo { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultQrcodeResultQrcodeVideosQrcodeVideo : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                    };

                    [NameInMap("PoliticsResult")]
                    [Validation(Required=false)]
                    public QueryMCJobListResponseBodyJobListJobResultPoliticsResult PoliticsResult { get; set; }
                    public class QueryMCJobListResponseBodyJobListJobResultPoliticsResult : TeaModel {
                        [NameInMap("PoliticsOcrs")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsOcrs PoliticsOcrs { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsOcrs : TeaModel {
                            [NameInMap("PoliticsOcr")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsOcrsPoliticsOcr> PoliticsOcr { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsOcrsPoliticsOcr : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("PoliticsVideos")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsVideos PoliticsVideos { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsVideos : TeaModel {
                            [NameInMap("PoliticsVideo")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsVideosPoliticsVideo> PoliticsVideo { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsVideosPoliticsVideo : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("PoliticsImages")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsImages PoliticsImages { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsImages : TeaModel {
                            [NameInMap("PoliticsImage")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsImagesPoliticsImage> PoliticsImage { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsImagesPoliticsImage : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Url")]
                                [Validation(Required=false)]
                                public string Url { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                        [NameInMap("PoliticsTexts")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsTexts PoliticsTexts { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsTexts : TeaModel {
                            [NameInMap("PoliticsText")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsTextsPoliticsText> PoliticsText { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsTextsPoliticsText : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                        [NameInMap("PoliticsAudios")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsAudios PoliticsAudios { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsAudios : TeaModel {
                            [NameInMap("PoliticsAudio")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsAudiosPoliticsAudio> PoliticsAudio { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultPoliticsResultPoliticsAudiosPoliticsAudio : TeaModel {
                                [NameInMap("EndTime")]
                                [Validation(Required=false)]
                                public string EndTime { get; set; }

                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                    };

                    [NameInMap("LiveResult")]
                    [Validation(Required=false)]
                    public QueryMCJobListResponseBodyJobListJobResultLiveResult LiveResult { get; set; }
                    public class QueryMCJobListResponseBodyJobListJobResultLiveResult : TeaModel {
                        [NameInMap("LiveImages")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultLiveResultLiveImages LiveImages { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultLiveResultLiveImages : TeaModel {
                            [NameInMap("LiveImage")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultLiveResultLiveImagesLiveImage> LiveImage { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultLiveResultLiveImagesLiveImage : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Url")]
                                [Validation(Required=false)]
                                public string Url { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                        [NameInMap("LiveVideos")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultLiveResultLiveVideos LiveVideos { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultLiveResultLiveVideos : TeaModel {
                            [NameInMap("LiveVideo")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultLiveResultLiveVideosLiveVideo> LiveVideo { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultLiveResultLiveVideosLiveVideo : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                    };

                    [NameInMap("AbuseResult")]
                    [Validation(Required=false)]
                    public QueryMCJobListResponseBodyJobListJobResultAbuseResult AbuseResult { get; set; }
                    public class QueryMCJobListResponseBodyJobListJobResultAbuseResult : TeaModel {
                        [NameInMap("AbuseOcrs")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultAbuseResultAbuseOcrs AbuseOcrs { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultAbuseResultAbuseOcrs : TeaModel {
                            [NameInMap("AbuseOcr")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultAbuseResultAbuseOcrsAbuseOcr> AbuseOcr { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultAbuseResultAbuseOcrsAbuseOcr : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("AbuseAudios")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultAbuseResultAbuseAudios AbuseAudios { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultAbuseResultAbuseAudios : TeaModel {
                            [NameInMap("AbuseAudio")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultAbuseResultAbuseAudiosAbuseAudio> AbuseAudio { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultAbuseResultAbuseAudiosAbuseAudio : TeaModel {
                                [NameInMap("EndTime")]
                                [Validation(Required=false)]
                                public string EndTime { get; set; }

                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("AbuseTexts")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultAbuseResultAbuseTexts AbuseTexts { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultAbuseResultAbuseTexts : TeaModel {
                            [NameInMap("AbuseText")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultAbuseResultAbuseTextsAbuseText> AbuseText { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultAbuseResultAbuseTextsAbuseText : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                    };

                    [NameInMap("SpamResult")]
                    [Validation(Required=false)]
                    public QueryMCJobListResponseBodyJobListJobResultSpamResult SpamResult { get; set; }
                    public class QueryMCJobListResponseBodyJobListJobResultSpamResult : TeaModel {
                        [NameInMap("SpamTexts")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultSpamResultSpamTexts SpamTexts { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultSpamResultSpamTexts : TeaModel {
                            [NameInMap("SpamText")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultSpamResultSpamTextsSpamText> SpamText { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultSpamResultSpamTextsSpamText : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                        [NameInMap("SpamAudios")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultSpamResultSpamAudios SpamAudios { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultSpamResultSpamAudios : TeaModel {
                            [NameInMap("SpamAudio")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultSpamResultSpamAudiosSpamAudio> SpamAudio { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultSpamResultSpamAudiosSpamAudio : TeaModel {
                                [NameInMap("EndTime")]
                                [Validation(Required=false)]
                                public string EndTime { get; set; }

                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("SpamOcrs")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultSpamResultSpamOcrs SpamOcrs { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultSpamResultSpamOcrs : TeaModel {
                            [NameInMap("SpamOcr")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultSpamResultSpamOcrsSpamOcr> SpamOcr { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultSpamResultSpamOcrsSpamOcr : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                    };

                    [NameInMap("ContrabandResult")]
                    [Validation(Required=false)]
                    public QueryMCJobListResponseBodyJobListJobResultContrabandResult ContrabandResult { get; set; }
                    public class QueryMCJobListResponseBodyJobListJobResultContrabandResult : TeaModel {
                        [NameInMap("ContrabandAudios")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultContrabandResultContrabandAudios ContrabandAudios { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultContrabandResultContrabandAudios : TeaModel {
                            [NameInMap("ContrabandAudio")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultContrabandResultContrabandAudiosContrabandAudio> ContrabandAudio { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultContrabandResultContrabandAudiosContrabandAudio : TeaModel {
                                [NameInMap("EndTime")]
                                [Validation(Required=false)]
                                public string EndTime { get; set; }

                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("ContrabandOcrs")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultContrabandResultContrabandOcrs ContrabandOcrs { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultContrabandResultContrabandOcrs : TeaModel {
                            [NameInMap("ContrabandOcr")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultContrabandResultContrabandOcrsContrabandOcr> ContrabandOcr { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultContrabandResultContrabandOcrsContrabandOcr : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("ContrabandTexts")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultContrabandResultContrabandTexts ContrabandTexts { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultContrabandResultContrabandTexts : TeaModel {
                            [NameInMap("ContrabandText")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultContrabandResultContrabandTextsContrabandText> ContrabandText { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultContrabandResultContrabandTextsContrabandText : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                    };

                    [NameInMap("TerrorismResult")]
                    [Validation(Required=false)]
                    public QueryMCJobListResponseBodyJobListJobResultTerrorismResult TerrorismResult { get; set; }
                    public class QueryMCJobListResponseBodyJobListJobResultTerrorismResult : TeaModel {
                        [NameInMap("TerrorismOcrs")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismOcrs TerrorismOcrs { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismOcrs : TeaModel {
                            [NameInMap("TerrorismOcr")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismOcrsTerrorismOcr> TerrorismOcr { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismOcrsTerrorismOcr : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("TerrorismAudios")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismAudios TerrorismAudios { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismAudios : TeaModel {
                            [NameInMap("TerrorismAudio")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismAudiosTerrorismAudio> TerrorismAudio { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismAudiosTerrorismAudio : TeaModel {
                                [NameInMap("EndTime")]
                                [Validation(Required=false)]
                                public string EndTime { get; set; }

                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("TerrorismVideos")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismVideos TerrorismVideos { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismVideos : TeaModel {
                            [NameInMap("TerrorismVideo")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismVideosTerrorismVideo> TerrorismVideo { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismVideosTerrorismVideo : TeaModel {
                                [NameInMap("Time")]
                                [Validation(Required=false)]
                                public string Time { get; set; }

                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Object")]
                                [Validation(Required=false)]
                                public string Object { get; set; }

                            }

                        }
                        [NameInMap("TerrorismTexts")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismTexts TerrorismTexts { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismTexts : TeaModel {
                            [NameInMap("TerrorismText")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismTextsTerrorismText> TerrorismText { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismTextsTerrorismText : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                        [NameInMap("TerrorismImages")]
                        [Validation(Required=false)]
                        public QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismImages TerrorismImages { get; set; }
                        public class QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismImages : TeaModel {
                            [NameInMap("TerrorismImage")]
                            [Validation(Required=false)]
                            public List<QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismImagesTerrorismImage> TerrorismImage { get; set; }
                            public class QueryMCJobListResponseBodyJobListJobResultTerrorismResultTerrorismImagesTerrorismImage : TeaModel {
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public string Score { get; set; }

                                [NameInMap("Url")]
                                [Validation(Required=false)]
                                public string Url { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                        }
                    };

                }
                public string State { get; set; }
                public string JobId { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public string PipelineId { get; set; }
            }
        };

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryMCJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryMCJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
