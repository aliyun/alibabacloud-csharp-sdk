// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QuerySmarttagTemplateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5210DBB0-E327-4D45-ADBC-0B83C8796E26</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The templates.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public QuerySmarttagTemplateListResponseBodyTemplates Templates { get; set; }
        public class QuerySmarttagTemplateListResponseBodyTemplates : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<QuerySmarttagTemplateListResponseBodyTemplatesTemplate> Template { get; set; }
            public class QuerySmarttagTemplateListResponseBodyTemplatesTemplate : TeaModel {
                /// <summary>
                /// <para>The analysis types that are used in the template. One or more values are returned. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ocr</b>: text recognition</description></item>
                /// <item><description><b>asr</b>: speech recognition</description></item>
                /// <item><description><b>classification</b>: video classification</description></item>
                /// <item><description><b>shows</b>: program recognition</description></item>
                /// <item><description><b>face</b>: facial recognition</description></item>
                /// <item><description><b>role</b>: figure recognition</description></item>
                /// <item><description><b>object</b>: object recognition</description></item>
                /// <item><description><b>tvstation</b>: logo recognition</description></item>
                /// <item><description><b>action</b>: action recognition</description></item>
                /// <item><description><b>emotion</b>: facial expression recognition</description></item>
                /// <item><description><b>landmark</b>: landmark recognition</description></item>
                /// <item><description><b>scene</b>: scene recognition</description></item>
                /// <item><description><b>movieip</b>: movie intellectual property recognition</description></item>
                /// <item><description><b>subtitle</b>: subtitle extraction</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ocr,asr,classification,shows,face,role,object,tvstation,action,emotion,landmark,scene</para>
                /// </summary>
                [NameInMap("AnalyseTypes")]
                [Validation(Required=false)]
                public string AnalyseTypes { get; set; }

                /// <summary>
                /// <para>The IDs of the system facial image libraries that are used in the template. One or more values are returned. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>celebrity: the facial image library of celebrities</description></item>
                /// <item><description>politician: the facial image library of politicians</description></item>
                /// <item><description>sensitive: the facial image library of sensitive figures</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>politician,sensitive,celebrity</para>
                /// </summary>
                [NameInMap("FaceCategoryIds")]
                [Validation(Required=false)]
                public string FaceCategoryIds { get; set; }

                /// <summary>
                /// <para>The configurations of face-related algorithms. The value of this parameter is a JSON string and consists of the thresholds set for face detection and facial recognition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>faceDetThreshold</b>: The default threshold for face detection is 0.999. The threshold takes effect only for the faces that are strange to the system.</description></item>
                /// <item><description><b>faceRegThreshold</b>: The default threshold for facial recognition is 0.9.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;faceDetThreshold&quot;:0.999, &quot;faceRegThreshold&quot;:0.9 }</para>
                /// </summary>
                [NameInMap("FaceCustomParamsConfig")]
                [Validation(Required=false)]
                public string FaceCustomParamsConfig { get; set; }

                /// <summary>
                /// <para>The industry to which the template applies. Default value: <b>common</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>microVideo</b>: short video industry</description></item>
                /// <item><description><b>common</b>: general industries</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>common</para>
                /// </summary>
                [NameInMap("Industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                /// <summary>
                /// <para>Indicates whether the template is the default template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The template is the default template.</description></item>
                /// <item><description><b>false</b>: The template is not the default template.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The configuration of keyword tags. The type field specifies the category of a keyword tag. You can specify one or more values and separate the values with commas (,). Valid values:</para>
                /// <list type="bullet">
                /// <item><description>name</description></item>
                /// <item><description>location</description></item>
                /// <item><description>organization</description></item>
                /// <item><description>other</description></item>
                /// </list>
                /// <remarks>
                /// <para>Keyword tags of all the categories are returned in one of the following scenarios: The KeywordConfig parameter is not specified or the Keyword field is invalid because it is not a JSON string, or the KeywordConfig parameter does not contain the type field or the type field is invalid.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;type&quot;: &quot;name,location,organization,other&quot; }</para>
                /// </summary>
                [NameInMap("KeywordConfig")]
                [Validation(Required=false)]
                public string KeywordConfig { get; set; }

                /// <summary>
                /// <para>The fields to be identified as knowledge graph information when tags are returned in Smart tagging V2.0 and Smart tagging V2.0-custom modes. For more information, see <a href="https://help.aliyun.com/document_detail/356383.html">Knowledge graph fields in smart tagging jobs</a>. If this parameter is not specified or the specified value is NULL or invalid because it is not a JSON string, the following fields are returned:</para>
                /// <list type="bullet">
                /// <item><description><para>movie-related fields:</para>
                /// <list type="bullet">
                /// <item><description>name: the name of the intellectual property that is featured in the movie</description></item>
                /// <item><description>alias: the alias of the intellectual property that is featured in the movie</description></item>
                /// <item><description>chnl: the category of the movie</description></item>
                /// <item><description>genre: the genre of the movie</description></item>
                /// <item><description>country: the country or region in which the movie was produced</description></item>
                /// <item><description>language: the language of the movie</description></item>
                /// <item><description>releaseYear: the year when the movie was released</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>music-related fields:</para>
                /// <list type="bullet">
                /// <item><description>songName: the name of the song</description></item>
                /// <item><description>artistName: the name of the singer</description></item>
                /// <item><description>artistArea: the region to which the singer belongs, such as China, Japan, Korea, Europe, and America, or others.</description></item>
                /// <item><description>albumName: the name of the album</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>person-related fields:</para>
                /// <list type="bullet">
                /// <item><description>name: the name of the person</description></item>
                /// <item><description>gender: the gender of the person</description></item>
                /// <item><description>citizenship: the nationality of the person</description></item>
                /// <item><description>occupation: the occupation of the person</description></item>
                /// <item><description>classification: the type into which the person is classified</description></item>
                /// <item><description>nationality: the ethnic group of the person</description></item>
                /// <item><description>birthPlace: the place where the person was born</description></item>
                /// <item><description>birthDate: the date when the person was born</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>landmark-related fields:</para>
                /// <list type="bullet">
                /// <item><description>name: the display name of the landmark</description></item>
                /// <item><description>nameEn: the English name of the landmark</description></item>
                /// <item><description>Description: the description of the parameter</description></item>
                /// <item><description>address: the address of the landmark</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>item-related fields:</para>
                /// <list type="bullet">
                /// <item><description>brandName: the brand of the item</description></item>
                /// <item><description>finegrainName: the fine-grained description of the item</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;movie&quot;:&quot;name,alias,chnl,genre&quot;, &quot;music&quot;:&quot;songName,artistName&quot;, &quot;person&quot;:&quot;name,gender&quot; }</para>
                /// </summary>
                [NameInMap("KnowledgeConfig")]
                [Validation(Required=false)]
                public string KnowledgeConfig { get; set; }

                /// <summary>
                /// <para>The type of the tagging. Default value: <b>auto</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>auto</b>: machine tagging</description></item>
                /// <item><description><b>hmi</b>: tagging by human and machine</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>hmi</para>
                /// </summary>
                [NameInMap("LabelType")]
                [Validation(Required=false)]
                public string LabelType { get; set; }

                /// <summary>
                /// <para>The version of the smart tagging feature. Default value: 1.0. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1.0: Smart tagging V1.0</description></item>
                /// <item><description>2.0: Smart tagging V2.0 (CPV tagging)</description></item>
                /// <item><description>2.0-custom: Smart tagging V2.0-custom (CPV tagging by using custom models)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("LabelVersion")]
                [Validation(Required=false)]
                public string LabelVersion { get; set; }

                /// <summary>
                /// <para>The IDs of the landmark libraries that are used in the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>common</para>
                /// </summary>
                [NameInMap("LandmarkGroupIds")]
                [Validation(Required=false)]
                public string LandmarkGroupIds { get; set; }

                /// <summary>
                /// <para>The IDs of the object libraries that are used in the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>general,item,weapon,animal</para>
                /// </summary>
                [NameInMap("ObjectGroupIds")]
                [Validation(Required=false)]
                public string ObjectGroupIds { get; set; }

                /// <summary>
                /// <para>The scenario in which the template is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>search</b>: search scenarios</description></item>
                /// <item><description><b>recommend</b>: recommendation scenarios</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>search</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The ID of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>05de22f255284c7a8d2aab535dde****</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <para>The name of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-****</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

        }

    }

}
