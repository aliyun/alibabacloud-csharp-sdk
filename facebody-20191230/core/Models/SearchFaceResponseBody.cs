// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class SearchFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchFaceResponseBodyData Data { get; set; }
        public class SearchFaceResponseBodyData : TeaModel {
            [NameInMap("MatchList")]
            [Validation(Required=false)]
            public List<SearchFaceResponseBodyDataMatchList> MatchList { get; set; }
            public class SearchFaceResponseBodyDataMatchList : TeaModel {
                [NameInMap("FaceItems")]
                [Validation(Required=false)]
                public List<SearchFaceResponseBodyDataMatchListFaceItems> FaceItems { get; set; }
                public class SearchFaceResponseBodyDataMatchListFaceItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>36.820168</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>U1</para>
                    /// </summary>
                    [NameInMap("EntityId")]
                    [Validation(Required=false)]
                    public string EntityId { get; set; }

                    [NameInMap("ExtraData")]
                    [Validation(Required=false)]
                    public string ExtraData { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>001</para>
                    /// </summary>
                    [NameInMap("FaceId")]
                    [Validation(Required=false)]
                    public string FaceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.892133</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public SearchFaceResponseBodyDataMatchListLocation Location { get; set; }
                public class SearchFaceResponseBodyDataMatchListLocation : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public int? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public int? Y { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>71.7349</para>
                /// </summary>
                [NameInMap("QualitieScore")]
                [Validation(Required=false)]
                public float? QualitieScore { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4159e64a-0fe8-436c-a8de-ee531555db3c</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
