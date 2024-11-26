// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yuqing20220301.Models
{
    public class SearchCondition : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;A&amp;&amp;B&quot;,&quot;C&quot;]</para>
        /// </summary>
        [NameInMap("assKeywordList")]
        [Validation(Required=false)]
        public List<string> AssKeywordList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("atAuthorNameList")]
        [Validation(Required=false)]
        public List<string> AtAuthorNameList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("authorNameList")]
        [Validation(Required=false)]
        public List<string> AuthorNameList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("commentsLevel")]
        [Validation(Required=false)]
        public int? CommentsLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("contentLenLevel")]
        [Validation(Required=false)]
        public int? ContentLenLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1620452881429</para>
        /// </summary>
        [NameInMap("createTimeEnd")]
        [Validation(Required=false)]
        public long? CreateTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1610452881429</para>
        /// </summary>
        [NameInMap("createTimeStart")]
        [Validation(Required=false)]
        public long? CreateTimeStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3478278371214</para>
        /// </summary>
        [NameInMap("docContentSign")]
        [Validation(Required=false)]
        public string DocContentSign { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5747368272834931</para>
        /// </summary>
        [NameInMap("docIdList")]
        [Validation(Required=false)]
        public List<string> DocIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("duplicateRemoval")]
        [Validation(Required=false)]
        public bool? DuplicateRemoval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("emotionType")]
        [Validation(Required=false)]
        public int? EmotionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableKeywordHighlight")]
        [Validation(Required=false)]
        public bool? EnableKeywordHighlight { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("excludeAtAuthorNameList")]
        [Validation(Required=false)]
        public List<string> ExcludeAtAuthorNameList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>新浪财经</para>
        /// </summary>
        [NameInMap("excludeAuthorNameList")]
        [Validation(Required=false)]
        public List<string> ExcludeAuthorNameList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>finance.sina.com.cn</para>
        /// </summary>
        [NameInMap("excludeHostNameList")]
        [Validation(Required=false)]
        public List<string> ExcludeHostNameList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;A&amp;&amp;B&quot;,&quot;C&quot;]</para>
        /// </summary>
        [NameInMap("excludeKeywordList")]
        [Validation(Required=false)]
        public List<string> ExcludeKeywordList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;A&amp;&amp;B&quot;,&quot;C&quot;]</para>
        /// </summary>
        [NameInMap("excludeKeywordListInTitle")]
        [Validation(Required=false)]
        public List<string> ExcludeKeywordListInTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123,456</para>
        /// </summary>
        [NameInMap("excludeKeywordTagIds")]
        [Validation(Required=false)]
        public List<long?> ExcludeKeywordTagIds { get; set; }

        [NameInMap("excludeMaterialTagList")]
        [Validation(Required=false)]
        public List<string> ExcludeMaterialTagList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123,456</para>
        /// </summary>
        [NameInMap("excludeMediaLibraryIdList")]
        [Validation(Required=false)]
        public List<string> ExcludeMediaLibraryIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>新浪财经</para>
        /// </summary>
        [NameInMap("excludeMediaNameList")]
        [Validation(Required=false)]
        public List<string> ExcludeMediaNameList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WEIBO-REPOST_WEIBO</para>
        /// </summary>
        [NameInMap("excludeMediaTypeList")]
        [Validation(Required=false)]
        public List<string> ExcludeMediaTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COMMENT</para>
        /// </summary>
        [NameInMap("excludeMessageTypeList")]
        [Validation(Required=false)]
        public List<string> ExcludeMessageTypeList { get; set; }

        [NameInMap("fieldConditions")]
        [Validation(Required=false)]
        public List<FieldCondition> FieldConditions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("filterId")]
        [Validation(Required=false)]
        public long? FilterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasAudio")]
        [Validation(Required=false)]
        public bool? HasAudio { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasImage")]
        [Validation(Required=false)]
        public bool? HasImage { get; set; }

        [NameInMap("hasMultiModeContent")]
        [Validation(Required=false)]
        public bool? HasMultiModeContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasVideo")]
        [Validation(Required=false)]
        public bool? HasVideo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>finance.sina.com.cn</para>
        /// </summary>
        [NameInMap("hostNameList")]
        [Validation(Required=false)]
        public List<string> HostNameList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("influenceLevel")]
        [Validation(Required=false)]
        public long? InfluenceLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123,456</para>
        /// </summary>
        [NameInMap("keywordTagIds")]
        [Validation(Required=false)]
        public List<long?> KeywordTagIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("likesLevel")]
        [Validation(Required=false)]
        public int? LikesLevel { get; set; }

        [NameInMap("materialTagList")]
        [Validation(Required=false)]
        public List<string> MaterialTagList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123,456</para>
        /// </summary>
        [NameInMap("mediaLibraryIdList")]
        [Validation(Required=false)]
        public List<string> MediaLibraryIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>新浪财经</para>
        /// </summary>
        [NameInMap("mediaNameList")]
        [Validation(Required=false)]
        public List<string> MediaNameList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WEIBO-REPOST_WEIBO</para>
        /// </summary>
        [NameInMap("mediaTypeList")]
        [Validation(Required=false)]
        public List<string> MediaTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COMMENT</para>
        /// </summary>
        [NameInMap("messageTypeList")]
        [Validation(Required=false)]
        public List<string> MessageTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNow")]
        [Validation(Required=false)]
        public int? PageNow { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>485738373837374</para>
        /// </summary>
        [NameInMap("parentDocId")]
        [Validation(Required=false)]
        public string ParentDocId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;A&amp;&amp;B&quot;,&quot;C&quot;]</para>
        /// </summary>
        [NameInMap("posKeywordList")]
        [Validation(Required=false)]
        public List<string> PosKeywordList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;A&amp;&amp;B&quot;,&quot;C&quot;]</para>
        /// </summary>
        [NameInMap("posKeywordListInTitle")]
        [Validation(Required=false)]
        public List<string> PosKeywordListInTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("propagationLevel")]
        [Validation(Required=false)]
        public long? PropagationLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1620452881429</para>
        /// </summary>
        [NameInMap("publishTimeEnd")]
        [Validation(Required=false)]
        public long? PublishTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1610452881429</para>
        /// </summary>
        [NameInMap("publishTimeStart")]
        [Validation(Required=false)]
        public long? PublishTimeStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("readsLevel")]
        [Validation(Required=false)]
        public int? ReadsLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("relevanceLevel")]
        [Validation(Required=false)]
        public int? RelevanceLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("repostLevel")]
        [Validation(Required=false)]
        public int? RepostLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PUBLISH_TIME</para>
        /// </summary>
        [NameInMap("sortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("sortByDirection")]
        [Validation(Required=false)]
        public string SortByDirection { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>#xxxx#</para>
        /// </summary>
        [NameInMap("topicList")]
        [Validation(Required=false)]
        public List<string> TopicList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1620452881429</para>
        /// </summary>
        [NameInMap("updateTimeEnd")]
        [Validation(Required=false)]
        public long? UpdateTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1610452881429</para>
        /// </summary>
        [NameInMap("updateTimeStart")]
        [Validation(Required=false)]
        public long? UpdateTimeStart { get; set; }

    }

}
