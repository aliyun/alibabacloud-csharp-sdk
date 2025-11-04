// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListHotwordLibrariesResponseBody : TeaModel {
        /// <summary>
        /// <para>The hotword libraries.</para>
        /// </summary>
        [NameInMap("HotwordLibraryList")]
        [Validation(Required=false)]
        public List<ListHotwordLibrariesResponseBodyHotwordLibraryList> HotwordLibraryList { get; set; }
        public class ListHotwordLibrariesResponseBodyHotwordLibraryList : TeaModel {
            /// <summary>
            /// <para>The time when the hotword library was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-11T12:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the hotword library. It can be up to 200 characters in length.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the hotword library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a93b91141c0f422fa114af203f8b****</para>
            /// </summary>
            [NameInMap("HotwordLibraryId")]
            [Validation(Required=false)]
            public string HotwordLibraryId { get; set; }

            /// <summary>
            /// <para>The time when the hotword library was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-11T12:00:00Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The name of the hotword library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_hotwords</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The usage scenario of the hotword library. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ASR: Automatic Speech Recognition</description></item>
            /// <item><description>StructuredMediaAssets: structured media analysis</description></item>
            /// <item><description>VideoTranslation: Video translation This field cannot be modified after the hotword library is created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASR</para>
            /// </summary>
            [NameInMap("UsageScenario")]
            [Validation(Required=false)]
            public string UsageScenario { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of hotword libraries that can be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token that can be used in the next request to retrieve a new page of results. If it is empty, all results are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBB6BC61D08</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>9262E3DA-07FA-4862-FCBB6BC61D08</b></b>*</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of hotword libraries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
