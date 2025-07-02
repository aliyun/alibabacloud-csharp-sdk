// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListMediaBasicInfosRequest : TeaModel {
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// <para>The business type of the media asset. Valid values:</para>
        /// <para>\- subtitles</para>
        /// <para>\- watermark</para>
        /// <para>\- opening</para>
        /// <para>\- ending</para>
        /// <para>\- general</para>
        /// 
        /// <b>Example:</b>
        /// <para>opening</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The end time of utcCreated.</para>
        /// <para>\- The value is the end of the left-open right-closed interval.</para>
        /// <para>\- Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. For example, 2017-01-11T12:00:00Z indicates 20:00:00 on January 11, 2017 (UTC +8).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-20T13:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the basic information of the source file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeFileBasicInfo")]
        [Validation(Required=false)]
        public bool? IncludeFileBasicInfo { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// <para>Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The ID of the media asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>019b82e24b37a1c2958dec38</b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The type of the media asset. Valid values:</para>
        /// <para>\- image</para>
        /// <para>\- video</para>
        /// <para>\- audio</para>
        /// <para>\- text</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pSa1SQ0wCe5pzVrQ6mWZEw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The order of sorting by utcCreated. Default value: desc. Valid values:</para>
        /// <para>\- desc</para>
        /// <para>\- asc</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The source of the media asset. Valid values:</para>
        /// <para>\- oss: Object Storage Service (OSS).</para>
        /// <para>\- vod: ApsaraVideo VOD.</para>
        /// <para>\- live: ApsaraVideo Live.</para>
        /// <para>\- general: other sources. This is the default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The start time of utcCreated.</para>
        /// <para>\- The value is the beginning of a left-open right-closed interval.</para>
        /// <para>\- Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. For example, 2017-01-11T12:00:00Z indicates 20:00:00 on January 11, 2017 (UTC +8).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-20T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the media asset. Valid values:</para>
        /// <para>\- Init: the initial state, which indicates that the source file is not ready.</para>
        /// <para>\- Preparing: The source file is being prepared. For example, the file is being uploaded or edited.</para>
        /// <para>\- PrepareFail: The source file failed to be prepared. For example, the information of the source file failed to be obtained.</para>
        /// <para>\- Normal: The source file is ready.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
