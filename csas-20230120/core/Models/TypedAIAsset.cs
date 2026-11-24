// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class TypedAIAsset : TeaModel {
        /// <summary>
        /// <para>The access method for the MCP. Valid values: local_process for local processes, remote_service for remote services, and unknown for undetermined methods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>local_process</para>
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// <para>The database primary key of the agent instance associated with the leaf asset, returned as a decimal numeric string. The value can be 0 when no agent is associated, and it can also be 0 in the details of the agent itself. This field is not returned in aggregated lists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456789</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The configuration path where the LLM, MCP, or tool declaration is located. This is not a skill package identifier. It is returned in instance details but not in aggregated lists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/example/.config/example-agent/config.json</para>
        /// </summary>
        [NameInMap("ConfigPath")]
        [Validation(Required=false)]
        public string ConfigPath { get; set; }

        /// <summary>
        /// <para>The description text collected for an MCP, tool, or skill. This is not returned if missing. Aggregated lists only return descriptions that are consistent within the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>读取并整理指定目录中的文档。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configured service endpoint for an LLM model service or remote MCP. Local stdio MCPs may not have this field. Its presence does not indicate a successful connection or actual invocation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://api.example.com/v1">https://api.example.com/v1</a></para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The classification of the LLM service endpoint. Valid values: official for official services, third_party for third-party services, and unknown for undetermined services. This classification does not represent a security detection conclusion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>official</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// <para>The time when the asset instance was first observed. The value is a database datetime string that may include six decimal places for seconds, without a unified time zone indicator. This field is not returned in aggregated lists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-16 10:30:00.000000</para>
        /// </summary>
        [NameInMap("FirstSeen")]
        [Validation(Required=false)]
        public string FirstSeen { get; set; }

        /// <summary>
        /// <para>The installation form of the agent, such as desktop_app, ide_extension, cli, or sdk. This is not the endpoint operating system such as Windows or macOS. The specific value is subject to the instance recognition result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cli</para>
        /// </summary>
        [NameInMap("Form")]
        [Validation(Required=false)]
        public string Form { get; set; }

        /// <summary>
        /// <para>The database primary key of the table where the asset instance is located, returned as a decimal numeric string to prevent precision loss of large integers. This is not the asset aggregation key AssetKey, and this instance field is not returned in aggregated lists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456789</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The collected product identity clues and their categorization by identifier type. These are used for auxiliary identification and do not indicate that signatures, publishers, or file contents have been authenticated through security authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;macos_bundle_id&quot;:[&quot;com.example.agent&quot;],&quot;npm_package&quot;:[&quot;@example/agent-cli&quot;]}</para>
        /// </summary>
        [NameInMap("IdentityIdentifiers")]
        [Validation(Required=false)]
        public TypedAIAssetIdentityIdentifiers IdentityIdentifiers { get; set; }
        public class TypedAIAssetIdentityIdentifiers : TeaModel {
            /// <summary>
            /// <para>The array of application names declared in desktop application manifests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;Example Agent&quot;]</para>
            /// </summary>
            [NameInMap("desktop_manifest_name")]
            [Validation(Required=false)]
            public List<string> DesktopManifestName { get; set; }

            /// <summary>
            /// <para>The array of plugin IDs declared in JetBrains plugin manifests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;com.example.agent.plugin&quot;]</para>
            /// </summary>
            [NameInMap("jetbrains_plugin_id")]
            [Validation(Required=false)]
            public List<string> JetbrainsPluginId { get; set; }

            /// <summary>
            /// <para>The array of macOS application bundle identifiers. These describe collected product identity clues and do not indicate that signatures are verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;com.example.agent&quot;]</para>
            /// </summary>
            [NameInMap("macos_bundle_id")]
            [Validation(Required=false)]
            public List<string> MacosBundleId { get; set; }

            /// <summary>
            /// <para>The array of npm package names. Scoped packages retain the @scope/name format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;@example/agent-cli&quot;]</para>
            /// </summary>
            [NameInMap("npm_package")]
            [Validation(Required=false)]
            public List<string> NpmPackage { get; set; }

            /// <summary>
            /// <para>The array of product name and company name combinations in Windows PE version resources. These are not file hashes or verified signature identities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;product_name&quot;:&quot;Example Agent&quot;,&quot;company_name&quot;:&quot;Example Corp&quot;}]</para>
            /// </summary>
            [NameInMap("pe_product_identity")]
            [Validation(Required=false)]
            public List<TypedAIAssetIdentityIdentifiersPeProductIdentity> PeProductIdentity { get; set; }
            public class TypedAIAssetIdentityIdentifiersPeProductIdentity : TeaModel {
                /// <summary>
                /// <para>The CompanyName field in a Windows PE version resource. This is not a certified vendor identity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Example Corp</para>
                /// </summary>
                [NameInMap("company_name")]
                [Validation(Required=false)]
                public string CompanyName { get; set; }

                /// <summary>
                /// <para>The ProductName field in a Windows PE version resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Example Agent</para>
                /// </summary>
                [NameInMap("product_name")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

            /// <summary>
            /// <para>The array of Python package distribution names. These are used for product identity identification and are not a list of import module names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;example-agent-sdk&quot;]</para>
            /// </summary>
            [NameInMap("pypi_package")]
            [Validation(Required=false)]
            public List<string> PypiPackage { get; set; }

            /// <summary>
            /// <para>The array of VS Code extension identifiers. Each is typically the publisher name and extension name connected by a dot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;example.agent-assistant&quot;]</para>
            /// </summary>
            [NameInMap("vscode_extension_id")]
            [Validation(Required=false)]
            public List<string> VscodeExtensionId { get; set; }

            /// <summary>
            /// <para>The array of Windows AppX/MSIX manifest identities. Each item provides both the package name and publisher. This does not indicate that the publisher signature is verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;Example.Agent&quot;,&quot;publisher&quot;:&quot;CN=Example Corp, O=Example Corp, C=US&quot;}]</para>
            /// </summary>
            [NameInMap("windows_appx_identity")]
            [Validation(Required=false)]
            public List<TypedAIAssetIdentityIdentifiersWindowsAppxIdentity> WindowsAppxIdentity { get; set; }
            public class TypedAIAssetIdentityIdentifiersWindowsAppxIdentity : TeaModel {
                /// <summary>
                /// <para>The original package name of the Identity.Name in a Windows AppX/MSIX manifest.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Example.Agent</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The publisher string of the Identity.Publisher in a Windows AppX/MSIX manifest. This is not equivalent to the signature verification result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN=Example Corp, O=Example Corp, C=US</para>
                /// </summary>
                [NameInMap("publisher")]
                [Validation(Required=false)]
                public string Publisher { get; set; }

            }

            /// <summary>
            /// <para>The array of Windows application package family names. Each includes the package name and publisher identifier suffix and is not the application installation path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;Example.Agent_123456789abcd&quot;]</para>
            /// </summary>
            [NameInMap("windows_package_family_name")]
            [Validation(Required=false)]
            public List<string> WindowsPackageFamilyName { get; set; }

        }

        /// <summary>
        /// <para>The installation path of the agent instance. This field is used only for instance details and is not returned in aggregated lists. It is not applicable to other asset types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/opt/example-agent</para>
        /// </summary>
        [NameInMap("InstallPath")]
        [Validation(Required=false)]
        public string InstallPath { get; set; }

        /// <summary>
        /// <para>The instance identity installed or declared within the endpoint, calculated by the script based on the asset type, ownership, and location. The identity scope must still include the tenant and endpoint, and it cannot be used as a globally unique ID across endpoints. This field is not returned in aggregation lists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha256:70e28ce51d55863f2ac5bb81efcee54026ff9fdde9b52346c659f4e24017e7f6</para>
        /// </summary>
        [NameInMap("InstanceLocalId")]
        [Validation(Required=false)]
        public string InstanceLocalId { get; set; }

        /// <summary>
        /// <para>The time of the last successful detection for the current skill content. This field is empty or not returned if no saved successful detection record exists. The value is a database datetime string without a unified time zone indicator. This field is not returned in aggregated lists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-16 10:30:00.000000</para>
        /// </summary>
        [NameInMap("LastCheckTime")]
        [Validation(Required=false)]
        public string LastCheckTime { get; set; }

        /// <summary>
        /// <para>The database ID of the latest detection task associated with the current skill content, returned as a decimal numeric string. The value can be 0 if no task is associated. The presence of a task ID does not indicate that the detection is complete. This field is not returned in aggregated lists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456791</para>
        /// </summary>
        [NameInMap("LastDetectTaskId")]
        [Validation(Required=false)]
        public string LastDetectTaskId { get; set; }

        /// <summary>
        /// <para>The time when the asset instance was last actually observed. The value is a database datetime string that may include six decimal places for seconds. This is not the page query time. This field is not returned in aggregated lists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-16 11:30:00.000000</para>
        /// </summary>
        [NameInMap("LastSeen")]
        [Validation(Required=false)]
        public string LastSeen { get; set; }

        /// <summary>
        /// <para>The array of static recognition basis tags matched by the agent, which can include model_call, tool_call, autonomous_execution, state_management, and agent_declaration. This does not indicate that the agent was actually executed or passed security certification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;model_call&quot;,&quot;tool_call&quot;]</para>
        /// </summary>
        [NameInMap("MatchedRules")]
        [Validation(Required=false)]
        public List<string> MatchedRules { get; set; }

        /// <summary>
        /// <para>The database primary key of the MCP instance associated with the tool, returned as a decimal numeric string. The value can be 0 when no MCP is associated, and this field is not applicable to other asset types. This field is not returned in aggregated lists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456790</para>
        /// </summary>
        [NameInMap("McpId")]
        [Validation(Required=false)]
        public string McpId { get; set; }

        /// <summary>
        /// <para>The product code of the agent. The specific value is subject to the product catalog in the recognition rules. This field is not returned when it is not applicable, unidentified, or inconsistent across aggregated attributes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example_agent</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The provider identifier matched based on the service endpoint and provider directory. This may not be returned if no match is found and is not the product code of the associated agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example_provider</para>
        /// </summary>
        [NameInMap("ProviderId")]
        [Validation(Required=false)]
        public string ProviderId { get; set; }

        /// <summary>
        /// <para>The provider display name of the tool. This is generated from the associated MCP, agent, or declaration source and is not a proof of security or trust.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example MCP</para>
        /// </summary>
        [NameInMap("ProviderName")]
        [Validation(Required=false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// <para>The Chinese display name of the service provider. The directory name is prioritized. The name parsed from the service endpoint may be used if no match is found. The presence of this field does not indicate that the service provider is identified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例模型服务商</para>
        /// </summary>
        [NameInMap("ProviderNameCn")]
        [Validation(Required=false)]
        public string ProviderNameCn { get; set; }

        /// <summary>
        /// <para>The English display name of the service provider. The directory name is prioritized. The name parsed from the service endpoint may be used if no match is found. The presence of this field does not indicate that the service provider is identified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example Model Provider</para>
        /// </summary>
        [NameInMap("ProviderNameEn")]
        [Validation(Required=false)]
        public string ProviderNameEn { get; set; }

        /// <summary>
        /// <para>The declared provider type of the tool. Valid values: mcp, agent, software, file, or unknown. This describes the declaration source and does not represent the actual caller, authorization status, or vendor identity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mcp</para>
        /// </summary>
        [NameInMap("ProviderType")]
        [Validation(Required=false)]
        public string ProviderType { get; set; }

        /// <summary>
        /// <para>The static recognition basis of the agent, which lists the source paths and evidence text grouped by recognition tags. This is not a runtime audit record, and instance-level evidence is not returned in aggregated lists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;model_call&quot;:[{&quot;source_path&quot;:&quot;/opt/example-agent/model.py&quot;}]}</para>
        /// </summary>
        [NameInMap("RecognitionEvidence")]
        [Validation(Required=false)]
        public TypedAIAssetRecognitionEvidence RecognitionEvidence { get; set; }
        public class TypedAIAssetRecognitionEvidence : TeaModel {
            /// <summary>
            /// <para>The array of evidence for explicit declarations of agent roles, capabilities, or usage methods. The declaration content itself does not constitute security certification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;source_path&quot;:&quot;/opt/example-agent/package.json&quot;,&quot;content&quot;:&quot;An AI agent that plans tasks and uses configured tools.&quot;}]</para>
            /// </summary>
            [NameInMap("agent_declaration")]
            [Validation(Required=false)]
            public List<TypedAIAssetRecognitionEvidenceAgentDeclaration> AgentDeclaration { get; set; }
            public class TypedAIAssetRecognitionEvidenceAgentDeclaration : TeaModel {
                /// <summary>
                /// <para>The collected declaration text related to the recognition basis. This is currently used mainly for agent_declaration, and other recognition evidence may not return content. This should not be interpreted as an actual execution log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>An AI agent that plans tasks and uses configured tools.</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The local file or configuration path where the recognition evidence is located. This is used to display and locate static clues, and is not a server-side downloadable URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/opt/example-agent/package.json</para>
                /// </summary>
                [NameInMap("source_path")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

            }

            /// <summary>
            /// <para>The array of static evidence related to autonomous task execution or agent loops. This does not indicate that actual execution was observed during this scan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;source_path&quot;:&quot;/opt/example-agent/agent.py&quot;}]</para>
            /// </summary>
            [NameInMap("autonomous_execution")]
            [Validation(Required=false)]
            public List<TypedAIAssetRecognitionEvidenceAutonomousExecution> AutonomousExecution { get; set; }
            public class TypedAIAssetRecognitionEvidenceAutonomousExecution : TeaModel {
                /// <summary>
                /// <para>The collected declaration text related to the recognition basis. This is currently used mainly for agent_declaration, and other recognition evidence may not return content. This should not be interpreted as an actual execution log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>An AI agent that plans tasks and uses configured tools.</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The local file or configuration path where the recognition evidence is located. This is used to display and locate static clues, and is not a server-side downloadable URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/opt/example-agent/package.json</para>
                /// </summary>
                [NameInMap("source_path")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

            }

            /// <summary>
            /// <para>The array of static evidence related to model clients, requests, or configurations. This does not indicate that model requests were actually sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;source_path&quot;:&quot;/opt/example-agent/model.py&quot;}]</para>
            /// </summary>
            [NameInMap("model_call")]
            [Validation(Required=false)]
            public List<TypedAIAssetRecognitionEvidenceModelCall> ModelCall { get; set; }
            public class TypedAIAssetRecognitionEvidenceModelCall : TeaModel {
                /// <summary>
                /// <para>The collected declaration text related to the recognition basis. This is currently used mainly for agent_declaration, and other recognition evidence may not return content. This should not be interpreted as an actual execution log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>An AI agent that plans tasks and uses configured tools.</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The local file or configuration path where the recognition evidence is located. This is used to display and locate static clues, and is not a server-side downloadable URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/opt/example-agent/package.json</para>
                /// </summary>
                [NameInMap("source_path")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

            }

            /// <summary>
            /// <para>The array of static evidence related to sessions, memory, or state management. This does not prove actual data persistence or runtime behavior.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;source_path&quot;:&quot;/opt/example-agent/session.py&quot;}]</para>
            /// </summary>
            [NameInMap("state_management")]
            [Validation(Required=false)]
            public List<TypedAIAssetRecognitionEvidenceStateManagement> StateManagement { get; set; }
            public class TypedAIAssetRecognitionEvidenceStateManagement : TeaModel {
                /// <summary>
                /// <para>The collected declaration text related to the recognition basis. This is currently used mainly for agent_declaration, and other recognition evidence may not return content. This should not be interpreted as an actual execution log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>An AI agent that plans tasks and uses configured tools.</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The local file or configuration path where the recognition evidence is located. This is used to display and locate static clues, and is not a server-side downloadable URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/opt/example-agent/package.json</para>
                /// </summary>
                [NameInMap("source_path")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

            }

            /// <summary>
            /// <para>The array of static evidence related to tool declarations or code to invoke tools. This does not indicate that the tools were actually executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;source_path&quot;:&quot;/opt/example-agent/tools.py&quot;}]</para>
            /// </summary>
            [NameInMap("tool_call")]
            [Validation(Required=false)]
            public List<TypedAIAssetRecognitionEvidenceToolCall> ToolCall { get; set; }
            public class TypedAIAssetRecognitionEvidenceToolCall : TeaModel {
                /// <summary>
                /// <para>The collected declaration text related to the recognition basis. This is currently used mainly for agent_declaration, and other recognition evidence may not return content. This should not be interpreted as an actual execution log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>An AI agent that plans tasks and uses configured tools.</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The local file or configuration path where the recognition evidence is located. This is used to display and locate static clues, and is not a server-side downloadable URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/opt/example-agent/package.json</para>
                /// </summary>
                [NameInMap("source_path")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

            }

        }

        /// <summary>
        /// <para>The product recognition status of the agent. identified indicates recognized, unidentified indicates pending recognition, and conflict indicates a recognition conflict. This status does not indicate whether the asset is secure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>identified</para>
        /// </summary>
        [NameInMap("RecognitionStatus")]
        [Validation(Required=false)]
        public string RecognitionStatus { get; set; }

        /// <summary>
        /// <para>The counts of high, medium, and low-risk items saved for the current skill content. This may be empty or not returned when no detection results are available. A missing value cannot be interpreted as a zero risk count or an indication of security.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;highRiskCnt&quot;:1,&quot;mediumRiskCnt&quot;:0,&quot;lowRiskCnt&quot;:0}</para>
        /// </summary>
        [NameInMap("RiskInfo")]
        [Validation(Required=false)]
        public TypedAIAssetRiskInfo RiskInfo { get; set; }
        public class TypedAIAssetRiskInfo : TeaModel {
            /// <summary>
            /// <para>The number of high-risk items in the currently saved detection results. This is interpreted as an actual count only when detection results are available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("highRiskCnt")]
            [Validation(Required=false)]
            public long? HighRiskCnt { get; set; }

            /// <summary>
            /// <para>The number of low-risk items in the currently saved detection results. A value of zero indicates no low-risk items in the results but does not indicate overall security.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lowRiskCnt")]
            [Validation(Required=false)]
            public long? LowRiskCnt { get; set; }

            /// <summary>
            /// <para>The number of medium-risk items in the currently saved detection results. A value of zero indicates no medium-risk items in the results but does not indicate the absence of other risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("mediumRiskCnt")]
            [Validation(Required=false)]
            public long? MediumRiskCnt { get; set; }

        }

        /// <summary>
        /// <para>The final risk level saved for the current skill content. This is not returned when no detection conclusion is available. The value high is provided only as a format example and does not serve as a new enumeration constraint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The scan batch identifier of the most recent scan where the instance was actually observed. This is not a database primary key or asset content hash. This field is not returned in aggregated lists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scan-0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("ScanId")]
        [Validation(Required=false)]
        public string ScanId { get; set; }

        /// <summary>
        /// <para>The source channel classification of the skill. The default value for current collection and storage is unknown. The unknown value cannot be inferred as an official or community source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unknown</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The SHA-256 hash of the complete skill package bytes. The format is a 64-character lowercase hexadecimal string without the sha256: prefix. The current script uses the skill-canonical-zip-v1 specification for compression. This is not equivalent to the installation instance ID and does not indicate that the package has been inspected or is secure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60d3292dd23fe7d2760d6a228123d1e4eb3d91bdb511089015e854d68ea9e460</para>
        /// </summary>
        [NameInMap("StandardSha256")]
        [Validation(Required=false)]
        public string StandardSha256 { get; set; }

        /// <summary>
        /// <para>The transport protocol declared in the MCP configuration. The collected value is retained as-is, such as stdio, sse, or streamable_http. This cannot be used to determine whether the service is running or has been invoked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stdio</para>
        /// </summary>
        [NameInMap("Transport")]
        [Validation(Required=false)]
        public string Transport { get; set; }

        /// <summary>
        /// <para>The vendor code for the collected and stored skill. The current default value is 1000. This cannot be used to infer a specific vendor or security status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public int? Vendor { get; set; }

        /// <summary>
        /// <para>The collected installation version of the agent. This field is not returned when the version is not collected. In aggregated lists, this field is returned only when the versions of all instances in the group are identical and not empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.3</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
