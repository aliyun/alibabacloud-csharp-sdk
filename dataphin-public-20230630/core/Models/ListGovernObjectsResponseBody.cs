// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListGovernObjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paged query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListGovernObjectsResponseBodyPageResult PageResult { get; set; }
        public class ListGovernObjectsResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The paged list of governance objects.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListGovernObjectsResponseBodyPageResultData> Data { get; set; }
            public class ListGovernObjectsResponseBodyPageResultData : TeaModel {
                /// <summary>
                /// <para>The time when the record was reported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-08-31 10:10:59</para>
                /// </summary>
                [NameInMap("CommitTime")]
                [Validation(Required=false)]
                public string CommitTime { get; set; }

                /// <summary>
                /// <para>The governance object ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>139487419630</para>
                /// </summary>
                [NameInMap("GovernItemId")]
                [Validation(Required=false)]
                public long? GovernItemId { get; set; }

                /// <summary>
                /// <para>The governance object ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-643545112181</para>
                /// </summary>
                [NameInMap("GovernObjectId")]
                [Validation(Required=false)]
                public long? GovernObjectId { get; set; }

                /// <summary>
                /// <para>Indicates whether rectification is in progress.</para>
                /// </summary>
                [NameInMap("IsRectify")]
                [Validation(Required=false)]
                public bool? IsRectify { get; set; }

                /// <summary>
                /// <para>The list of owners.</para>
                /// </summary>
                [NameInMap("Owners")]
                [Validation(Required=false)]
                public List<ListGovernObjectsResponseBodyPageResultDataOwners> Owners { get; set; }
                public class ListGovernObjectsResponseBodyPageResultDataOwners : TeaModel {
                    /// <summary>
                    /// <para>The display name of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Yang Jing 2088252351182803</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The governance issue object.</para>
                /// </summary>
                [NameInMap("Problem")]
                [Validation(Required=false)]
                public ListGovernObjectsResponseBodyPageResultDataProblem Problem { get; set; }
                public class ListGovernObjectsResponseBodyPageResultDataProblem : TeaModel {
                    /// <summary>
                    /// <para>The object ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9223058119411358258</para>
                    /// </summary>
                    [NameInMap("ObjectId")]
                    [Validation(Required=false)]
                    public string ObjectId { get; set; }

                    /// <summary>
                    /// <para>The ID of the parent object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>913836</para>
                    /// </summary>
                    [NameInMap("ParentObjectId")]
                    [Validation(Required=false)]
                    public string ParentObjectId { get; set; }

                    /// <summary>
                    /// <para>The contact email for the governance issue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="mailto:126983612986391@gamail.com">126983612986391@gamail.com</a></para>
                    /// </summary>
                    [NameInMap("ProblemContactMail")]
                    [Validation(Required=false)]
                    public string ProblemContactMail { get; set; }

                    /// <summary>
                    /// <para>The other contact information for the governance issue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Jane</para>
                    /// </summary>
                    [NameInMap("ProblemContactOther")]
                    [Validation(Required=false)]
                    public string ProblemContactOther { get; set; }

                    /// <summary>
                    /// <para>The contact phone number for the governance issue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16278902467</para>
                    /// </summary>
                    [NameInMap("ProblemContactPhone")]
                    [Validation(Required=false)]
                    public string ProblemContactPhone { get; set; }

                    /// <summary>
                    /// <para>The description of the governance issue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Governance issue description</para>
                    /// </summary>
                    [NameInMap("ProblemDesc")]
                    [Validation(Required=false)]
                    public string ProblemDesc { get; set; }

                    /// <summary>
                    /// <para>The submission type of the issue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SYSTEM</para>
                    /// </summary>
                    [NameInMap("ProblemSubmitType")]
                    [Validation(Required=false)]
                    public string ProblemSubmitType { get; set; }

                    /// <summary>
                    /// <para>The user who submitted the issue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("ProblemSubmitter")]
                    [Validation(Required=false)]
                    public string ProblemSubmitter { get; set; }

                    /// <summary>
                    /// <para>The username of the issue submitter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>John</para>
                    /// </summary>
                    [NameInMap("ProblemSubmitterUserName")]
                    [Validation(Required=false)]
                    public string ProblemSubmitterUserName { get; set; }

                    /// <summary>
                    /// <para>The types of the governance issue.</para>
                    /// </summary>
                    [NameInMap("ProblemTypes")]
                    [Validation(Required=false)]
                    public List<string> ProblemTypes { get; set; }

                }

                /// <summary>
                /// <para>The property values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///                     &quot;gmt_create&quot;: &quot;2026-08-31 06:00:22.296&quot;,
                ///                     &quot;index_compute_type&quot;: &quot;&quot;,
                ///                     &quot;table_env&quot;: &quot;PROD&quot;,
                ///                     &quot;table_datasource_id&quot;: &quot;1&quot;,
                ///                     &quot;owner_id&quot;: &quot;300006218&quot;,
                ///                     &quot;index_catalog&quot;: &quot;&quot;,
                ///                     &quot;qd_feature_owner&quot;: &quot;&quot;,
                ///                     &quot;rule_task_start_time&quot;: &quot;2026-08-31 06:00:00&quot;,
                ///                     &quot;table_id&quot;: &quot;odps.300023201.fashion_ads.api2mysql_demo&quot;,
                ///                     &quot;rule_strength&quot;: &quot;WEAK&quot;,
                ///                     &quot;table_biz_unit_name&quot;: &quot;LD_Fashion&quot;,
                ///                     &quot;table_name&quot;: &quot;fashion_ads.api2mysql_demo&quot;,
                ///                     &quot;index_type&quot;: &quot;&quot;,
                ///                     &quot;table_datasource_from&quot;: &quot;META_DATA&quot;,
                ///                     &quot;datasource_type&quot;: &quot;MaxCompute&quot;,
                ///                     &quot;datasource_scope&quot;: &quot;OFFLINE&quot;,
                ///                     &quot;template_zh_tw_name&quot;: &quot;欄位空值校正&quot;,
                ///                     &quot;problem_submit_type&quot;: &quot;SYSTEM&quot;,
                ///                     &quot;template_type&quot;: &quot;FIELD_NULL_VALUE_VALIDATE&quot;,
                ///                     &quot;index_name_cn&quot;: &quot;&quot;,
                ///                     &quot;datasource_name&quot;: &quot;Dataphin&quot;,
                ///                     &quot;id&quot;: &quot;918363&quot;,
                ///                     &quot;index_id&quot;: &quot;&quot;,
                ///                     &quot;validate_partition&quot;: &quot;ds=\&quot;20260831\&quot;&quot;,
                ///                     &quot;index_owner_id&quot;: &quot;&quot;,
                ///                     &quot;datasource_owner&quot;: &quot;300006218&quot;,
                ///                     &quot;rule_name&quot;: &quot;date_odps_test_2025-09-22 20:32:07&quot;,
                ///                     &quot;watch_type&quot;: &quot;TABLE&quot;,
                ///                     &quot;validate_status&quot;: &quot;NOT_PASS&quot;,
                ///                     &quot;qd_feature_id&quot;: &quot;&quot;,
                ///                     &quot;table_desc&quot;: &quot;api2mysql_demo&quot;,
                ///                     &quot;is_ignore&quot;: &quot;false&quot;,
                ///                     &quot;rule_desc&quot;: &quot;&quot;,
                ///                     &quot;table_partitioned&quot;: &quot;true&quot;,
                ///                     &quot;template_owner&quot;: &quot;300006218&quot;,
                ///                     &quot;index_biz_unit_id&quot;: &quot;&quot;,
                ///                     &quot;table_biz_unit_id&quot;: &quot;6865277495315392&quot;,
                ///                     &quot;index_biz_unit_name&quot;: &quot;&quot;,
                ///                     &quot;watch_env&quot;: &quot;PROD&quot;,
                ///                     &quot;problem_contact_other&quot;: &quot;&quot;,
                ///                     &quot;status&quot;: &quot;NEW&quot;,
                ///                     &quot;datasource_from&quot;: &quot;META_DATA&quot;,
                ///                     &quot;table_project_name&quot;: &quot;fashion_ads&quot;,
                ///                     &quot;tenant_id&quot;: &quot;300023201&quot;,
                ///                     &quot;datasource_env&quot;: &quot;PROD&quot;,
                ///                     &quot;template_en_name&quot;: &quot;Verify Field Null Values&quot;,
                ///                     &quot;commit_time&quot;: &quot;2026-08-31 06:00:21.135&quot;,
                ///                     &quot;gmt_modified&quot;: &quot;2026-08-31 06:00:22.296&quot;,
                ///                     &quot;qd_feature_name&quot;: &quot;&quot;,
                ///                     &quot;table_catalog&quot;: &quot;fashion_ads&quot;,
                ///                     &quot;rule_status&quot;: &quot;ENABLE&quot;,
                ///                     &quot;problem_contact_mail&quot;: &quot;&quot;,
                ///                     &quot;rule_task_status&quot;: &quot;SUCCESS&quot;,
                ///                     &quot;rule_validate_object_type&quot;: &quot;COLUMN&quot;,
                ///                     &quot;watch_status&quot;: &quot;ENABLE&quot;,
                ///                     &quot;index_guid&quot;: &quot;&quot;,
                ///                     &quot;system_template&quot;: &quot;true&quot;,
                ///                     &quot;quality_owners&quot;: &quot;300006218&quot;,
                ///                     &quot;index_name&quot;: &quot;&quot;,
                ///                     &quot;problem_contact_phone&quot;: &quot;&quot;,
                ///                     &quot;watch_task_id&quot;: &quot;8325922&quot;,
                ///                     &quot;rule_task_id&quot;: &quot;8328383&quot;,
                ///                     &quot;index_desc&quot;: &quot;&quot;,
                ///                     &quot;table_type&quot;: &quot;PHYSICAL_TABLE&quot;,
                ///                     &quot;table_project_id&quot;: &quot;6865331520706176&quot;,
                ///                     &quot;trace_id&quot;: &quot;time:4326023&quot;,
                ///                     &quot;datasource_id&quot;: &quot;1&quot;,
                ///                     &quot;qd_feature_code&quot;: &quot;&quot;,
                ///                     &quot;rule_validate_object_name&quot;: &quot;date_odps&quot;,
                ///                     &quot;problem_desc&quot;: &quot;date_odps_test_2025-09-22 20:32:07&quot;,
                ///                     &quot;table_owner&quot;: &quot;300006218&quot;,
                ///                     &quot;quality_owner_groups&quot;: &quot;&quot;,
                ///                     &quot;govern_item_id&quot;: &quot;100&quot;,
                ///                     &quot;rule_catalogs&quot;: &quot;COMPLETENESS&quot;,
                ///                     &quot;table_datasource_type&quot;: &quot;MAX_COMPUTE&quot;,
                ///                     &quot;template_zh_cn_name&quot;: &quot;字段空值校验&quot;,
                ///                     &quot;rule_task_biz_date&quot;: &quot;20260831 06:00:00&quot;,
                ///                     &quot;problem_types&quot;: &quot;[{\&quot;value\&quot;:\&quot;COMPLETENESS\&quot;}]&quot;,
                ///                     &quot;rule_id&quot;: &quot;4322944&quot;,
                ///                     &quot;problem_attachment_file_ids&quot;: &quot;null&quot;,
                ///                     &quot;watch_name&quot;: &quot;&quot;,
                ///                     &quot;template_name&quot;: &quot;&quot;,
                ///                     &quot;schedule_params&quot;: &quot;&quot;,
                ///                     &quot;is_rectify&quot;: &quot;false&quot;,
                ///                     &quot;rule_task_end_time&quot;: &quot;&quot;,
                ///                     &quot;watch_id&quot;: &quot;3841908&quot;,
                ///                     &quot;validate_result&quot;: &quot;false&quot;,
                ///                     &quot;qd_feature_guid&quot;: &quot;&quot;,
                ///                     &quot;govern_object_id&quot;: &quot;913836&quot;,
                ///                     &quot;template_id&quot;: &quot;100&quot;</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public Dictionary<string, object> Properties { get; set; }

                /// <summary>
                /// <para>The rectification ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-787032739353</para>
                /// </summary>
                [NameInMap("RectifyId")]
                [Validation(Required=false)]
                public long? RectifyId { get; set; }

                /// <summary>
                /// <para>The name of the rectification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test rectification</para>
                /// </summary>
                [NameInMap("RectifyName")]
                [Validation(Required=false)]
                public string RectifyName { get; set; }

                /// <summary>
                /// <para>The rectification status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NEW</para>
                /// </summary>
                [NameInMap("RectifyStatus")]
                [Validation(Required=false)]
                public string RectifyStatus { get; set; }

                /// <summary>
                /// <para>The related knowledge base entries.</para>
                /// </summary>
                [NameInMap("RelatedKnowledge")]
                [Validation(Required=false)]
                public List<ListGovernObjectsResponseBodyPageResultDataRelatedKnowledge> RelatedKnowledge { get; set; }
                public class ListGovernObjectsResponseBodyPageResultDataRelatedKnowledge : TeaModel {
                    /// <summary>
                    /// <para>The cause of the issue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Host exception. The instance was migrated with data loss</para>
                    /// </summary>
                    [NameInMap("Cause")]
                    [Validation(Required=false)]
                    public string Cause { get; set; }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Store scheduled power on/off business domain canary list\n</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <para>The knowledge entry ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-341426256859</para>
                    /// </summary>
                    [NameInMap("KnowledgeId")]
                    [Validation(Required=false)]
                    public long? KnowledgeId { get; set; }

                    /// <summary>
                    /// <para>The owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-mnneiiwtemj-wjuggee</para>
                    /// </summary>
                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    /// <summary>
                    /// <para>The name of the owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>buc_459782</para>
                    /// </summary>
                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <para>The Solutions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;Type\&quot;:\&quot;text\&quot;,\&quot;Value\&quot;:\&quot;OSS public network access\&quot;}</para>
                    /// </summary>
                    [NameInMap("Solution")]
                    [Validation(Required=false)]
                    public string Solution { get; set; }

                    /// <summary>
                    /// <para>The title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Makassar International Eight Festival &amp; Forum (F8 Makassar)</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The status of the governance object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
