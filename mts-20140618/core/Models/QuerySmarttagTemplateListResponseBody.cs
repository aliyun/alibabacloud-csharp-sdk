// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QuerySmarttagTemplateListResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The templates.
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
                /// The analysis types that are used in the template. One or more values are returned. Valid values:
                /// 
                /// *   **ocr**: text recognition
                /// *   **asr**: speech recognition
                /// *   **classification**: video classification
                /// *   **shows**: program recognition
                /// *   **face**: facial recognition
                /// *   **role**: figure recognition
                /// *   **object**: object recognition
                /// *   **tvstation**: logo recognition
                /// *   **action**: action recognition
                /// *   **emotion**: facial expression recognition
                /// *   **landmark**: landmark recognition
                /// *   **scene**: scene recognition
                /// *   **movieip**: movie intellectual property recognition
                /// *   **subtitle**: subtitle extraction
                /// </summary>
                [NameInMap("AnalyseTypes")]
                [Validation(Required=false)]
                public string AnalyseTypes { get; set; }

                /// <summary>
                /// The IDs of the system facial image libraries that are used in the template. One or more values are returned. Valid values:
                /// 
                /// *   celebrity: the facial image library of celebrities
                /// *   politician: the facial image library of politicians
                /// *   sensitive: the facial image library of sensitive figures
                /// </summary>
                [NameInMap("FaceCategoryIds")]
                [Validation(Required=false)]
                public string FaceCategoryIds { get; set; }

                /// <summary>
                /// The configurations of face-related algorithms. The value of this parameter is a JSON string and consists of the thresholds set for face detection and facial recognition. Valid values:
                /// 
                /// *   **faceDetThreshold**: The default threshold for face detection is 0.999. The threshold takes effect only for the faces that are strange to the system.
                /// *   **faceRegThreshold**: The default threshold for facial recognition is 0.9.
                /// </summary>
                [NameInMap("FaceCustomParamsConfig")]
                [Validation(Required=false)]
                public string FaceCustomParamsConfig { get; set; }

                /// <summary>
                /// The industry to which the template applies. Default value: **common**. Valid values:
                /// 
                /// *   **microVideo**: short video industry
                /// *   **common**: general industries
                /// </summary>
                [NameInMap("Industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                /// <summary>
                /// Indicates whether the template is the default template. Valid values:
                /// 
                /// *   **true**: The template is the default template.
                /// *   **false**: The template is not the default template.
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// The configuration of keyword tags. The type field specifies the category of a keyword tag. You can specify one or more values and separate the values with commas (,). Valid values:
                /// 
                /// *   name
                /// *   location
                /// *   organization
                /// *   other
                /// 
                /// > Keyword tags of all the categories are returned in one of the following scenarios: The KeywordConfig parameter is not specified or the Keyword field is invalid because it is not a JSON string, or the KeywordConfig parameter does not contain the type field or the type field is invalid.
                /// </summary>
                [NameInMap("KeywordConfig")]
                [Validation(Required=false)]
                public string KeywordConfig { get; set; }

                /// <summary>
                /// The fields to be identified as knowledge graph information when tags are returned in Smart tagging V2.0 and Smart tagging V2.0-custom modes. For more information, see [Knowledge graph fields in smart tagging jobs](https://help.aliyun.com/document_detail/356383.html). If this parameter is not specified or the specified value is NULL or invalid because it is not a JSON string, the following fields are returned:
                /// 
                /// *   movie-related fields:
                /// 
                ///     *   name: the name of the intellectual property that is featured in the movie
                ///     *   alias: the alias of the intellectual property that is featured in the movie
                ///     *   chnl: the category of the movie
                ///     *   genre: the genre of the movie
                ///     *   country: the country or region in which the movie was produced
                ///     *   language: the language of the movie
                ///     *   releaseYear: the year when the movie was released
                /// 
                /// *   music-related fields:
                /// 
                ///     *   songName: the name of the song
                ///     *   artistName: the name of the singer
                ///     *   artistArea: the region to which the singer belongs, such as China, Japan, Korea, Europe, and America, or others.
                ///     *   albumName: the name of the album
                /// 
                /// *   person-related fields:
                /// 
                ///     *   name: the name of the person
                ///     *   gender: the gender of the person
                ///     *   citizenship: the nationality of the person
                ///     *   occupation: the occupation of the person
                ///     *   classification: the type into which the person is classified
                ///     *   nationality: the ethnic group of the person
                ///     *   birthPlace: the place where the person was born
                ///     *   birthDate: the date when the person was born
                /// 
                /// *   landmark-related fields:
                /// 
                ///     *   name: the display name of the landmark
                ///     *   nameEn: the English name of the landmark
                ///     *   Description: the description of the parameter
                ///     *   address: the address of the landmark
                /// 
                /// *   item-related fields:
                /// 
                ///     *   brandName: the brand of the item
                ///     *   finegrainName: the fine-grained description of the item
                /// </summary>
                [NameInMap("KnowledgeConfig")]
                [Validation(Required=false)]
                public string KnowledgeConfig { get; set; }

                /// <summary>
                /// The type of the tagging. Default value: **auto**. Valid values:
                /// 
                /// *   **auto**: machine tagging
                /// *   **hmi**: tagging by human and machine
                /// </summary>
                [NameInMap("LabelType")]
                [Validation(Required=false)]
                public string LabelType { get; set; }

                /// <summary>
                /// The version of the smart tagging feature. Default value: 1.0. Valid values:
                /// 
                /// *   1.0: Smart tagging V1.0
                /// *   2.0: Smart tagging V2.0 (CPV tagging)
                /// *   2.0-custom: Smart tagging V2.0-custom (CPV tagging by using custom models)
                /// </summary>
                [NameInMap("LabelVersion")]
                [Validation(Required=false)]
                public string LabelVersion { get; set; }

                /// <summary>
                /// The IDs of the landmark libraries that are used in the template.
                /// </summary>
                [NameInMap("LandmarkGroupIds")]
                [Validation(Required=false)]
                public string LandmarkGroupIds { get; set; }

                /// <summary>
                /// The IDs of the object libraries that are used in the template.
                /// </summary>
                [NameInMap("ObjectGroupIds")]
                [Validation(Required=false)]
                public string ObjectGroupIds { get; set; }

                /// <summary>
                /// The scenario in which the template is used. Valid values:
                /// 
                /// *   **search**: search scenarios
                /// *   **recommend**: recommendation scenarios
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// The ID of the template.
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// The name of the template.
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

        }

    }

}
