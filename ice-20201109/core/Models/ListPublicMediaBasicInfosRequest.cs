// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListPublicMediaBasicInfosRequest : TeaModel {
        /// <summary>
        /// <para>The business type of the media asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sticker</description></item>
        /// <item><description>bgm</description></item>
        /// <item><description>bgi</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sticker</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the basic information of the media asset.</para>
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
        /// <para>The media tag. All media assets that contain the specified media tag are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Sticker tags:</para>
        /// <list type="bullet">
        /// <item><description>sticker-atmosphere</description></item>
        /// <item><description>sticker-bubble</description></item>
        /// <item><description>sticker-cute</description></item>
        /// <item><description>sticker-daily</description></item>
        /// <item><description>sticker-expression</description></item>
        /// <item><description>sticker-gif</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Background music (BGM) tags:</para>
        /// <list type="bullet">
        /// <item><description>bgm-romantic</description></item>
        /// <item><description>bgm-cuisine</description></item>
        /// <item><description>bgm-chinese-style</description></item>
        /// <item><description>bgm-upbeat</description></item>
        /// <item><description>bgm-dynamic</description></item>
        /// <item><description>bgm-relaxing</description></item>
        /// <item><description>bgm-quirky</description></item>
        /// <item><description>bgm-beauty</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Background image (BGI) tags:</para>
        /// <list type="bullet">
        /// <item><description>bgi-grad</description></item>
        /// <item><description>bgi-solid</description></item>
        /// <item><description>bgi-pic</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ticker-atmosphere</para>
        /// </summary>
        [NameInMap("MediaTagId")]
        [Validation(Required=false)]
        public string MediaTagId { get; set; }

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
        /// <para>The page number. Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
