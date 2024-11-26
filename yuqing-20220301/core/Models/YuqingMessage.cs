// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yuqing20220301.Models
{
    public class YuqingMessage : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Alipay</para>
        /// </summary>
        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("appScore")]
        [Validation(Required=false)]
        public long? AppScore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HUAWEI_APPSTORE</para>
        /// </summary>
        [NameInMap("appStoreName")]
        [Validation(Required=false)]
        public string AppStoreName { get; set; }

        [NameInMap("atAuthorNames")]
        [Validation(Required=false)]
        public List<string> AtAuthorNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("audioCount")]
        [Validation(Required=false)]
        public int? AudioCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxx.png">https://xxx.png</a></para>
        /// </summary>
        [NameInMap("authorAvatarUrl")]
        [Validation(Required=false)]
        public string AuthorAvatarUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("authorFollowersCount")]
        [Validation(Required=false)]
        public long? AuthorFollowersCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("authorFriendsCount")]
        [Validation(Required=false)]
        public long? AuthorFriendsCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f</para>
        /// </summary>
        [NameInMap("authorGender")]
        [Validation(Required=false)]
        public string AuthorGender { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("authorId")]
        [Validation(Required=false)]
        public string AuthorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("authorLikesCount")]
        [Validation(Required=false)]
        public long? AuthorLikesCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("authorName")]
        [Validation(Required=false)]
        public string AuthorName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxx">http://xxx</a></para>
        /// </summary>
        [NameInMap("authorProfileUrl")]
        [Validation(Required=false)]
        public string AuthorProfileUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("authorStatusesCount")]
        [Validation(Required=false)]
        public long? AuthorStatusesCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("authorVerified")]
        [Validation(Required=false)]
        public bool? AuthorVerified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("authorVerifyType")]
        [Validation(Required=false)]
        public int? AuthorVerifyType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;xxx&quot;,&quot;yyy&quot;]</para>
        /// </summary>
        [NameInMap("contentAudioText")]
        [Validation(Required=false)]
        public string ContentAudioText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;<a href="http://xx.mp3%22,%22http://yy.mp3%22%5D">http://xx.mp3&quot;,&quot;http://yy.mp3&quot;]</a></para>
        /// </summary>
        [NameInMap("contentAudioUrls")]
        [Validation(Required=false)]
        public string ContentAudioUrls { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;xxx&quot;,&quot;yyy&quot;]</para>
        /// </summary>
        [NameInMap("contentImageText")]
        [Validation(Required=false)]
        public string ContentImageText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;<a href="http://xx.png%22,%22http://xx.jpeg%22%5D">http://xx.png&quot;,&quot;http://xx.jpeg&quot;]</a></para>
        /// </summary>
        [NameInMap("contentImageUrls")]
        [Validation(Required=false)]
        public string ContentImageUrls { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("contentLang")]
        [Validation(Required=false)]
        public string ContentLang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("contentLen")]
        [Validation(Required=false)]
        public long? ContentLen { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;xxx&quot;,&quot;yyy&quot;]</para>
        /// </summary>
        [NameInMap("contentVideoText")]
        [Validation(Required=false)]
        public string ContentVideoText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;<a href="http://xx.mpeg%22,%22http://yy.mp4%22%5D">http://xx.mpeg&quot;,&quot;http://yy.mp4&quot;]</a></para>
        /// </summary>
        [NameInMap("contentVideoUrls")]
        [Validation(Required=false)]
        public string ContentVideoUrls { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>165202930291</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("docAnswersCount")]
        [Validation(Required=false)]
        public long? DocAnswersCount { get; set; }

        [NameInMap("docAreas")]
        [Validation(Required=false)]
        public List<string> DocAreas { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("docCoinCount")]
        [Validation(Required=false)]
        public long? DocCoinCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("docCommentsCount")]
        [Validation(Required=false)]
        public long? DocCommentsCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("docContent")]
        [Validation(Required=false)]
        public string DocContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("docContentBrief")]
        [Validation(Required=false)]
        public string DocContentBrief { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>81728391712912</para>
        /// </summary>
        [NameInMap("docContentSign")]
        [Validation(Required=false)]
        public string DocContentSign { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>48573837837232</para>
        /// </summary>
        [NameInMap("docId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("docLikesCount")]
        [Validation(Required=false)]
        public long? DocLikesCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("docPlayCount")]
        [Validation(Required=false)]
        public long? DocPlayCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("docReadingCount")]
        [Validation(Required=false)]
        public long? DocReadingCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("docReadsCount")]
        [Validation(Required=false)]
        public long? DocReadsCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("docRepostsCount")]
        [Validation(Required=false)]
        public long? DocRepostsCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>成都日报</para>
        /// </summary>
        [NameInMap("docReprintName")]
        [Validation(Required=false)]
        public string DocReprintName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>81728391712912</para>
        /// </summary>
        [NameInMap("docSelfContentSign")]
        [Validation(Required=false)]
        public string DocSelfContentSign { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("docTitle")]
        [Validation(Required=false)]
        public string DocTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxx">http://xxx</a></para>
        /// </summary>
        [NameInMap("docUrl")]
        [Validation(Required=false)]
        public string DocUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4.3</para>
        /// </summary>
        [NameInMap("emotionScore")]
        [Validation(Required=false)]
        public double? EmotionScore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("emotionType")]
        [Validation(Required=false)]
        public int? EmotionType { get; set; }

        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("finEventCount")]
        [Validation(Required=false)]
        public int? FinEventCount { get; set; }

        [NameInMap("financeEventList")]
        [Validation(Required=false)]
        public List<YuqingFinanceEvent> FinanceEventList { get; set; }

        [NameInMap("highlightKeywords")]
        [Validation(Required=false)]
        public List<string> HighlightKeywords { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("imageCount")]
        [Validation(Required=false)]
        public int? ImageCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4.1</para>
        /// </summary>
        [NameInMap("influenceScore")]
        [Validation(Required=false)]
        public double? InfluenceScore { get; set; }

        [NameInMap("mediaHosts")]
        [Validation(Required=false)]
        public List<string> MediaHosts { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("mediaInfluenceLevel")]
        [Validation(Required=false)]
        public int? MediaInfluenceLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>新浪财经</para>
        /// </summary>
        [NameInMap("mediaName")]
        [Validation(Required=false)]
        public string MediaName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("mediaPropagationLevel")]
        [Validation(Required=false)]
        public int? MediaPropagationLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WEIBO-REPOST_WEIBO</para>
        /// </summary>
        [NameInMap("mediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COMMENT</para>
        /// </summary>
        [NameInMap("messageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>484747382721</para>
        /// </summary>
        [NameInMap("parentDocId")]
        [Validation(Required=false)]
        public string ParentDocId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3.9</para>
        /// </summary>
        [NameInMap("propagationScore")]
        [Validation(Required=false)]
        public double? PropagationScore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>165202930291</para>
        /// </summary>
        [NameInMap("publishTime")]
        [Validation(Required=false)]
        public long? PublishTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5.2</para>
        /// </summary>
        [NameInMap("relevanceScore")]
        [Validation(Required=false)]
        public double? RelevanceScore { get; set; }

        [NameInMap("reportMaterialTags")]
        [Validation(Required=false)]
        public List<string> ReportMaterialTags { get; set; }

        [NameInMap("repostList")]
        [Validation(Required=false)]
        public List<string> RepostList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("similarNumber")]
        [Validation(Required=false)]
        public int? SimilarNumber { get; set; }

        [NameInMap("topics")]
        [Validation(Required=false)]
        public List<string> Topics { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("videoCount")]
        [Validation(Required=false)]
        public int? VideoCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4837383832323</para>
        /// </summary>
        [NameInMap("weiboCommentId")]
        [Validation(Required=false)]
        public string WeiboCommentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>465758363823</para>
        /// </summary>
        [NameInMap("weiboMid")]
        [Validation(Required=false)]
        public string WeiboMid { get; set; }

    }

}
