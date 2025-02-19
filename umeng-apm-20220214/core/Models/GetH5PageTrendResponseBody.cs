// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class GetH5PageTrendResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetH5PageTrendResponseBodyData> Data { get; set; }
        public class GetH5PageTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>504.89</para>
            /// </summary>
            [NameInMap("analyzeDOM")]
            [Validation(Required=false)]
            public double? AnalyzeDOM { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>49.48</para>
            /// </summary>
            [NameInMap("appCache")]
            [Validation(Required=false)]
            public double? AppCache { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>979.83</para>
            /// </summary>
            [NameInMap("contentTrans")]
            [Validation(Required=false)]
            public double? ContentTrans { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50.16</para>
            /// </summary>
            [NameInMap("dns")]
            [Validation(Required=false)]
            public double? Dns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1881.96</para>
            /// </summary>
            [NameInMap("domReady")]
            [Validation(Required=false)]
            public double? DomReady { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>190.69</para>
            /// </summary>
            [NameInMap("fcp")]
            [Validation(Required=false)]
            public double? Fcp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>472.57</para>
            /// </summary>
            [NameInMap("firstByte")]
            [Validation(Required=false)]
            public double? FirstByte { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>44.67</para>
            /// </summary>
            [NameInMap("fiveSecondRate")]
            [Validation(Required=false)]
            public double? FiveSecondRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50.25</para>
            /// </summary>
            [NameInMap("fp")]
            [Validation(Required=false)]
            public double? Fp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>492.86</para>
            /// </summary>
            [NameInMap("loadEvent")]
            [Validation(Required=false)]
            public double? LoadEvent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4741.44</para>
            /// </summary>
            [NameInMap("loadFinish")]
            [Validation(Required=false)]
            public double? LoadFinish { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2549.46</para>
            /// </summary>
            [NameInMap("loadResource")]
            [Validation(Required=false)]
            public double? LoadResource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2062</para>
            /// </summary>
            [NameInMap("logCnt")]
            [Validation(Required=false)]
            public long? LogCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.19</para>
            /// </summary>
            [NameInMap("oneSecondRate")]
            [Validation(Required=false)]
            public double? OneSecondRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100.93</para>
            /// </summary>
            [NameInMap("redirect")]
            [Validation(Required=false)]
            public double? Redirect { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>71.02</para>
            /// </summary>
            [NameInMap("ssl")]
            [Validation(Required=false)]
            public double? Ssl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>150.18</para>
            /// </summary>
            [NameInMap("tcp")]
            [Validation(Required=false)]
            public double? Tcp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-05-20</para>
            /// </summary>
            [NameInMap("timePoint")]
            [Validation(Required=false)]
            public string TimePoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>249.55</para>
            /// </summary>
            [NameInMap("ttfb")]
            [Validation(Required=false)]
            public double? Ttfb { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2126.61</para>
            /// </summary>
            [NameInMap("tti")]
            [Validation(Required=false)]
            public double? Tti { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4.9</para>
            /// </summary>
            [NameInMap("twoSecondRate")]
            [Validation(Required=false)]
            public double? TwoSecondRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>98.26</para>
            /// </summary>
            [NameInMap("unload")]
            [Validation(Required=false)]
            public double? Unload { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>succeed in handling request</para>
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
